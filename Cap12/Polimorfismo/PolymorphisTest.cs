using System;

namespace Cap12.Polimorfismo
{
    public class PolymorphisTest
    {
        public static void Principal()
        {
            var commissionEmployee = new CommissionEmployee("Sue","Jones","222-22-2222",10000.00M,.06M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob","Lewis","333-33-3333",5000.00M,0.04M,300.00M);

            Console.WriteLine($"Call CommissionEmployee's ToString and Earnings methods "+
                "with base-class reference to base class object\n");
            Console.WriteLine(commissionEmployee.ToString());
            Console.WriteLine($"earnings: {commissionEmployee.Earnings()}\n");
            
            Console.WriteLine($"Call BasePlusCommissionEmployee's ToString and "+
                "Earnings methods with derived class reference to "+
                "derived-class object\n");
            Console.WriteLine(basePlusCommissionEmployee.ToString());
            Console.WriteLine($"earning: {basePlusCommissionEmployee.Earnings()}\n");
            
            CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;
            Console.WriteLine($"Call BasePlusCommisionEmployee's ToString and Earnings "+
                "methods with base class reference to derived-class object");
            Console.WriteLine(commissionEmployee2.ToString());
            Console.WriteLine($"earnings: {commissionEmployee2.Earnings()}");
        }
    }
}