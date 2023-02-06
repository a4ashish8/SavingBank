using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingBank
{
    internal interface IBankAccount
    {
        bool Deposit_ammount(float DAmmount);
        bool WithDrawl_Ammount(float WAmmount);
        float Check_Ammount();
    }
}
