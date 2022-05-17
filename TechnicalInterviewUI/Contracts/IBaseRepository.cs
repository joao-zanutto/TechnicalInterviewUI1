using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalInterviewUI.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Get a unique value
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="id">an guid id</param>
        /// <returns></returns>
        Task<T> Get(string url, Guid id);
        /// <summary>
        /// get a list
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <returns>a list</returns>
        Task<IList<T>> Get(string url);
        /// <summary>
        /// get a list that maches with the object that you sent
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="obj">fulfilled object</param>
        /// <returns>a filtered list</returns>
        Task<IList<T>> Get(string url, T obj);
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="obj">object to create</param>
        /// <returns>a list with the created object</returns>
        Task<bool> Create(string url, T obj);
        /// <summary>
        /// update
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="obj">as updates parameters</param>
        /// <returns>true when success</returns>
        Task<bool> Update(string url, T obj);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="id">id</param>
        /// <returns>true when success</returns>
        Task<bool> Delete(string url, string id);
    }
}