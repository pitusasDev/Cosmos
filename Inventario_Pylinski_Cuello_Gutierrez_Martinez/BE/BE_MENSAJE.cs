using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_MENSAJE
    {
        public int Myid { get; set; }
        public string Myusuarioorigen { get; set; }
        public string MyUsuariodestino { get; set; }
        public string MyContenido { get; set; }

        public BE_MENSAJE()
        {

        }
        public BE_MENSAJE(int id, string myusuarioorigen, string myUsuariodestino, string myContenido)
        {
            Myid = id;
            Myusuarioorigen = myusuarioorigen;
            MyUsuariodestino = myUsuariodestino;
            MyContenido = myContenido;
        }
        public BE_MENSAJE(string myusuarioorigen, string myUsuariodestino, string myContenido)
        {
            Myusuarioorigen = myusuarioorigen;
            MyUsuariodestino = myUsuariodestino;
            MyContenido = myContenido;
        }
    }
}
