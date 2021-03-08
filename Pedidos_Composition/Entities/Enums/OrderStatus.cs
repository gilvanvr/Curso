using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos_Composition.Entities.Enums
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered =3
    };
}
