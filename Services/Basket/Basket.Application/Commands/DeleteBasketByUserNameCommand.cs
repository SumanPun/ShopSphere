using MediatR;

namespace Basket.Application.Commands
{
    public class DeleteBasketByUserNameCommand : IRequest<Unit>
    {
        public string UserName { get; set; }
        public DeleteBasketByUserNameCommand()
        {
            
        }
        public DeleteBasketByUserNameCommand(string userName)
        {
            UserName = userName;
        }
    }
}
