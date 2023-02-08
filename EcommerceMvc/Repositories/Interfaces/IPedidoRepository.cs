using EcommerceMvc.Models;

namespace EcommerceMvc.Repositories.Interfaces;

public interface IPedidoRepository
{
    void CriarPedido(Pedido pedido);
}
