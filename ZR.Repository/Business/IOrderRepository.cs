using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZR.Model.Business.Dto;
using ZR.Model.Business;

namespace ZR.Repository.Business
{
    public interface IOrderRepository
    {
        Task<int> InsertOrder(Order order);
        Task<IEnumerable<OrderListDto>> SelectOrders(long userId, int roleId, int page, int size);
        Task<OrderDetailDto> SelectOrderById(int docEntry, long userId, int roleId);
        Task<bool> UpdateOrder(Order order);
        Task<bool> DeleteOrder(int docEntry);
    }


}
