
using Core.Entity;
using Core.GenericDataAccessRepository.Abstract;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Core.GenericDataAccessRepository.Concrete.DapperFramework
{
    public class DapperEntityRepositoryBase<TEntity> : DapperEntityAttrConf<TEntity>, IEntitiyRepository<TEntity>
        where TEntity : class, IEntity, new()
        
    {
        private readonly string _conStr = "Server=localhost;Database=dapperGeneric;Trusted_Connection=true";
       
        public void add(TEntity Entity)
        {
            using (SqlConnection context = new SqlConnection(_conStr))
            {
                string tableName = GetTableName();
                string columns = GetColumns(true);
                string properties = GetPropertyNames(true);
                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({properties})";
                context.Execute(query,Entity);
            }
        }

        public void delete(TEntity Entity)
        {
            using (SqlConnection context = new SqlConnection(_conStr))
            {
                string tableName = GetTableName();
                string keyColumn = GetKeyColumnName();
                string keyPrpoerty = GetKeyPropertyName();
                string query = $"DELETE FROM {tableName} WHERE {keyColumn} = @{keyPrpoerty}";
                context.Execute(query, Entity);
            }
        }

        public TEntity Get(int id, Expression<Func<TEntity, bool>> filter = null)
        {
            using (SqlConnection context = new SqlConnection(_conStr))
            {
                string tableName = GetTableName();
                string keyColumn = GetKeyColumnName();
                string query = $"SELECT * FROM {tableName} WHERE {keyColumn} =" + id;
                return context.Query<TEntity>(query).FirstOrDefault();
            }
        }

        public  List<TEntity> getAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (SqlConnection context = new SqlConnection(_conStr))
            {
                string tableName = GetTableName();
                string query = $"SELECT * FROM {tableName}";
                return context.Query<TEntity>(query).ToList();
            }
        }

        public void update(TEntity Entity)
        {
            using (SqlConnection context = new SqlConnection(_conStr))
            {
                string tableName = GetTableName();
                string keyColumn = GetKeyColumnName();
                string keyProperty = GetKeyPropertyName();
                StringBuilder query = new StringBuilder();
                query.Append($"UPDATE {tableName} SET ");

                foreach (var property in GetProperties(true))
                {
                    var columnAttr = property.GetCustomAttribute<ColumnAttribute>();

                    string propertyName = property.Name;
                    string columnName = columnAttr.Name;

                    query.Append($"{columnName} = @{propertyName},");
                }
                query.Remove(query.Length - 1, 1);
                query.Append($" WHERE {keyColumn} = @{keyProperty}");

                 context.Execute(query.ToString(), Entity);
            }
        }
    }
}
