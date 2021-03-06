﻿using Dapper;
using MISA.eSHOP.DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.eSHOP.DataLayer
{
    public class BaseDLQuery<T> : IBaseDL<T> where T : class
    {
        private readonly IDbContext<T> _dbContext;

        public BaseDLQuery(IDbContext<T> dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Thực thi proceduce lấy tất cả
        /// Đặt tên proc theo kiểu Proc_GetAll...
        /// </summary>
        /// <returns>Danh sách thực thể</returns>
        /// CreatedBy Vtthien 09/02/21
        public IEnumerable<T> GetAll()
        {
            var sqlString = $"SELECT * FROM {typeof(T).Name} ORDER BY ModifiedDate DESC";
            var entities = _dbContext.Query(sqlString);

            return entities;
        }

        /// <summary>
        /// Thực thi proceduce lấy theo id
        /// Đặt tên proc theo kiểu Proc_Get...ById
        /// </summary>
        /// <param name="id">Id</param>
        /// CreatedBy Vtthien 09/02/21
        /// <returns>Danh sách thực thể</returns>
        public T GetById(Guid id)
        {
            var sqlString = $"SELECT * FROM {typeof(T).Name} WHERE {typeof(T).Name}ID = '{id.ToString()}'";
            
            var entity = _dbContext.QueryFirst(sqlString);
            return entity;
        }

        public IEnumerable<T> GetByIDParent(Guid id, string parentField)
        {
            var sqlString = $"SELECT * FROM {typeof(T).Name} WHERE {parentField} = '{id.ToString()}'";
            var entities = _dbContext.Query(sqlString);

            return entities;
        }

        /// <summary>
        /// Thực thi proceduce insert
        /// Đặt tên proc theo kiểu Proc_Insert...
        /// </summary>
        /// <param name="entity">Thực thể cần thêm</param>
        /// <returns>Số bản ghi thay đổi</returns>
        /// CreatedBy VTThien 09/02/21
        public int Insert(T entity)
        {
            var procName = "Proc_Insert" + typeof(T).Name;
            var parameters = new DynamicParameters(entity);
            var result = _dbContext.Excute(procName, parameters, CommandType.StoredProcedure);
            return result;
        }

        /// <summary>
        /// Thực thi proceduce update
        /// Đặt tên proc theo kiểu Proc_Update...
        /// </summary>
        /// <param name="entity">Thực thể cần sửa</param>
        /// <returns>Số bản ghi thay đổi</returns>
        /// CreatedBy VTThien 09/02/21
        public int Update(T entity)
        {
            var procName = "Proc_Update" + typeof(T).Name;
            var parameters = new DynamicParameters(entity);
            var result = _dbContext.Excute(procName, parameters, CommandType.StoredProcedure);
            return result;
        }

        /// <summary>
        /// Thực thi proceduce delete
        /// Đặt tên proc theo kiểu Proc_Delete...
        /// </summary>
        /// <param name="entity">Thực thể cần xóa</param>
        /// <returns>Số bản ghi thay đổi</returns>
        /// CreatedBy VTThien 09/02/21
        public int Delete(Guid id)
        {
            var sqlString = $"DELETE FROM {typeof(T).Name} WHERE {typeof(T).Name}ID = '{id.ToString()}'";
            
            var result = _dbContext.Excute(sqlString);
            return result;
        }

        /// <summary>
        /// Check trùng mã
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public T GetEntityByCode(string code)
        {
            string tableName = typeof(T).Name;
            string fieldCode = tableName + "Code";

            var sql = $"SELECT * FROM {tableName} WHERE {fieldCode} = '{code}'";
            var result = _dbContext.QueryFirst(sql);
            return result;
        }

        /// <summary>
        /// Check trùng theo tên trường
        /// </summary>
        /// <param name="fieldName">Tên trường cần check trùng</param>
        /// <param name="fieldValue">Giá trị</param>
        /// <returns></returns>
        public T GetEntityByField(string fieldName, string fieldValue)
        {
            string tableName = typeof(T).Name;

            var sql = $"SELECT * FROM {tableName} WHERE {fieldName} = '{fieldValue}'";
            var result = _dbContext.QueryFirst(sql);
            return result;
        }

    }
}
