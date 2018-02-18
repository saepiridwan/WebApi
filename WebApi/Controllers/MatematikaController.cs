using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MatematikaController : ApiController
    {
        /// <summary>
        /// Mengembalikan bilangan 1 sampai 10
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> Get()
        {
            return new int[] { 1,2,3,4,5,6,7,8,9,10 };
        }
        /// <summary>
        /// Mengembalikan string dari angka yang dimasukkan 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            string result = String.Empty;
            if (id.Equals(1))
            {
                result = "Satu";
            }
            else if (id.Equals(2))
            {
                result = "Dua";
            }
            else if (id.Equals(3))
            {
                result = "Tiga";
            }
            else if (id.Equals(4))
            {
                result = "Empat";
            }
            else if (id.Equals(5))
            {
                result = "Lima";
            }
            else if (id.Equals(6))
            {
                result = "Enam";
            }
            else if (id.Equals(7))
            {
                result = "Tujuh";
            }
            else if (id.Equals(8))
            {
                result = "Delapan";
            }
            else if (id.Equals(9))
            {
                result = "Sembilan";
            }
            else if (id.Equals(10))
            {
                result = "Sepuluh";
            }

            return result;
        }
        /// <summary>
        /// Operasi matematika sederhana
        /// </summary>
        /// <param name="op">Operator</param>
        /// <param name="bil1">Bilangan 1</param>
        /// <param name="bil2">Bilangan 2</param>
        /// <returns></returns>
        public double Get(string op, string bil1, string bil2)
        {
            double result = 0;
            int bilangan1 = Convert.ToInt32(bil1);
            int bilangan2 = Convert.ToInt32(bil2);

            if (op.Equals("Tambah"))
            {
                result = bilangan1 + bilangan2;
            }
            else if (op.Equals("Kurang"))
            {
                result = bilangan1 - bilangan2;
            }
            else if (op.Equals("Kali"))
            {
                result = bilangan1 * bilangan2;
            }
            else if (op.Equals("Bagi"))
            {
                result = bilangan1 / bilangan2;
            }

            return result;
        }
    }
}
