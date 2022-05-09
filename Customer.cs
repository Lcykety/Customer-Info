using System.Collections;


namespace Customerİnfo
{
    public class Customer
    {
        #region Virtual Database
        static ArrayList CustomerDatabase;

        #endregion
        #region Static creater 
        static Customer()
        {
            CustomerDatabase = new ArrayList();
        }
        #endregion

        #region capsulation
        /*
         * in this region, we have fields for Customer's informations.
         * also program does capsulation process in this ragion.
         */
        public int id { get; set; }
        public string Name { get; set; }
        public string lastname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        private string user;
        public string userName
        {
            get { return this.user; }
            set
            {
                bool nickcont = NickController(value);
                if (nickcont)
                {
                    System.Console.WriteLine("İstediğiniz Kullanıcı adı Kullanımdadır.");
                    this.user = string.Empty;
                }
                else
                {
                    System.Console.WriteLine("Başarıyla kaydedildi");
                    this.user = value;
                }
            }
        }
        #endregion
        /*
         * In this region, program has static methods for username and Mail control
         * 
         */
        #region Static Methods
        static bool NickController(string user)
        {
            bool NickControl = false;

            for (int i = 0; i < CustomerDatabase.Count; i++)
            {
                Customer customer = (Customer)CustomerDatabase[i];
                Customer Temp = customer;
                if (Temp.userName == user)
                {
                    NickControl = true;
                    break;
                }

            }
            return NickControl; 
        }
            public static void AddCustomer(Customer customer)
        {
            #region parameterControl
            if (customer != null && !string.IsNullOrEmpty(customer.userName) && !string.IsNullOrEmpty(customer.Mail))
            {
                bool maCont=Mailcontrol(customer.Mail);
                if (maCont)
                {
                    System.Console.WriteLine("Mail zaten Kayıtlı");

                }
                else
                {
                    CustomerDatabase.Add(customer);
                    System.Console.WriteLine("Mail kaydı başarılı");
                }
            }
            static bool Mailcontrol(string _mail)
            {
               bool mailControl=false;
                for(int i=0; i<CustomerDatabase.Count; i++)
                {
                     Customer Temp= (Customer) CustomerDatabase[i];
                    if(Temp.Mail == _mail)
                    {
                       mailControl=true;
                        break;
                    }

                }
                return mailControl;






            }
            #endregion
        }
        #endregion


    }
}
