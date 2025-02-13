using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZR.Model.Business.Dto;

namespace ZR.Service.Business.IBusinessService
{
    public interface IOrderService
    {
        Task<(bool Success, string Message, int DocEntry)> CreateOrder(OrderDto orderDto, long userId);
        Task<IEnumerable<OrderListDto>> GetOrders(long userId, int roleId, int page, int size);
        Task<OrderDetailDto> GetOrderById(int docEntry, long userId, int roleId);
        Task<(bool Success, string Message)> UpdateOrder(int docEntry, OrderUpdateDto orderUpdateDto, long userId);
        Task<(bool Success, string Message)> DeleteOrder(int docEntry, long userId, int roleId);
    }
}
