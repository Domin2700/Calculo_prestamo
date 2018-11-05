using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Caluladora_Prestamo
{
    class Mantenimiento
    {

        private SQLEntities db = new SQLEntities();



        public void InsertClientes(Cliente campos)
        {
            Clientes cliente = new Clientes();

            cliente.NOMBRES = campos.NOMBRES;
            cliente.APELLIDOS = campos.APELLIDOS;
            cliente.CEDULA = campos.CEDULA;
            cliente.CELULAR = campos.CELULAR;
            cliente.DIRECCION = campos.DIRECION;

            db.Clientes.Add(cliente);
            db.SaveChanges();


        }

        public void InsertTarifa(Tarifa campos)
        {

            tarifas tarifa = new tarifas();

            tarifa.MONTO = campos.MONTO;
            tarifa.MONTO_CUOTA = campos.MONTO_CUOTA;
            tarifa.NO_CUOTA = campos.NO_CUOTA;
            tarifa.TIPO = campos.TIPO;
            db.tarifas.Add(tarifa);
            db.SaveChanges();



        }


        public List<Tarifa> SelectTarifa()
        {
            var tarifa = from Tr in db.tarifas
                         select Tr;


            List < Tarifa > tarif = new List<Tarifa>();
            foreach (var campos in tarifa)
            {
                tarif.Add(new Tarifa {

                    ID_TARIFA = Convert.ToInt16(campos.ID_TARIFA),
                    MONTO = float.Parse(campos.MONTO.ToString()),
                    MONTO_CUOTA = float.Parse(campos.MONTO_CUOTA.ToString()),
                    NO_CUOTA = Convert.ToInt16(campos.NO_CUOTA),
                    TIPO = Convert.ToInt16(campos.TIPO)
                });


            }

            return tarif;


        }

        public void UpdateTarifa(Tarifa campos)
        {
            var tarifa = db.tarifas.Where(id => id.ID_TARIFA == campos.ID_TARIFA).FirstOrDefault();
            tarifa.MONTO = campos.MONTO;
            tarifa.MONTO_CUOTA = campos.MONTO_CUOTA;
            tarifa.NO_CUOTA = campos.NO_CUOTA;
            tarifa.TIPO = campos.TIPO;
            db.SaveChanges();


        }

        public void DeleteTarifa(int idt)
        {
            var tarifa = db.tarifas.Where(id => id.ID_TARIFA == idt).FirstOrDefault();

            db.tarifas.Remove(tarifa);
            db.SaveChanges();
        }



        public List<Cliente> SelectClietes()
        {

            var Clientes = from Cl in db.Clientes
                           select Cl;

            List<Cliente> Client = new List<Cliente>();

            foreach(var campos in Clientes)
            {
                Client.Add(new Cliente {

                    ID_CLIENTE = Convert.ToInt16(campos.ID_CLIENTE),
                    NOMBRES = campos.NOMBRES,
                    APELLIDOS = campos.APELLIDOS,
                    CEDULA = campos.CEDULA,
                    CELULAR = campos.CELULAR,
                    DIRECION = campos.DIRECCION

                });


            }

            return Client;


        }


       

        









    }
}
