using System;

namespace ProblemaPedido.Entities.Enums
{
enum OrderStatus : int
    {
        PeningPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered =3
    }
}
