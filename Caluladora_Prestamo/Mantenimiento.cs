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
            cliente.DIRECCION = campos.DIRECCION;

            db.Clientes.Add(cliente);
            db.SaveChanges();


        }

        public List<Cliente> SelectClietes()
        {

            var Clientes = from Cl in db.Clientes
                           select Cl;

            List<Cliente> Client = new List<Cliente>();

            foreach (var campos in Clientes)
            {
                Client.Add(new Cliente
                {

                    ID_CLIENTE = Convert.ToInt16(campos.ID_CLIENTE),
                    NOMBRES = campos.NOMBRES,
                    APELLIDOS = campos.APELLIDOS,
                    CEDULA = campos.CEDULA,
                    CELULAR = campos.CELULAR,
                    DIRECCION = campos.DIRECCION

                });


            }

            return Client;


        }


        public List<Cliente> SelectClietes(string buscar)
        {

            var Clientes = from Cl in db.Clientes
                           where Cl.NOMBRES.Contains(buscar) || Cl.APELLIDOS.Contains(buscar) || Cl.CEDULA.Contains(buscar)
                           select Cl;

            List<Cliente> Client = new List<Cliente>();

            foreach (var campos in Clientes)
            {
                Client.Add(new Cliente
                {

                    ID_CLIENTE = Convert.ToInt16(campos.ID_CLIENTE),
                    NOMBRES = campos.NOMBRES,
                    APELLIDOS = campos.APELLIDOS,
                    CEDULA = campos.CEDULA,
                    CELULAR = campos.CELULAR,
                    DIRECCION = campos.DIRECCION

                });


            }

            return Client;


        }

        public List<Cliente> SelectClietes(int id)
        {

            var Clientes = from Cl in db.Clientes
                           where Cl.ID_CLIENTE == id
                           select Cl;

            List<Cliente> Client = new List<Cliente>();

            foreach (var campos in Clientes)
            {
                Client.Add(new Cliente
                {

                    ID_CLIENTE = Convert.ToInt16(campos.ID_CLIENTE),
                    NOMBRES = campos.NOMBRES,
                    APELLIDOS = campos.APELLIDOS,
                    CEDULA = campos.CEDULA,
                    CELULAR = campos.CELULAR,
                    DIRECCION = campos.DIRECCION

                });


            }

            return Client;


        }


        public void DeleteCliente(int idc)
        {
            var cliente = db.Clientes.Where(id => id.ID_CLIENTE == idc).FirstOrDefault();

            db.Clientes.Remove(cliente);
            db.SaveChanges();




        }

        public void UpdateCliente(Cliente campos)
        {
            var cliente = db.Clientes.Where(id => id.ID_CLIENTE == campos.ID_CLIENTE).FirstOrDefault();

            cliente.NOMBRES = campos.NOMBRES;
            cliente.APELLIDOS = campos.APELLIDOS;
            cliente.CEDULA = campos.CEDULA;
            cliente.CELULAR = campos.CELULAR;
            cliente.DIRECCION = campos.DIRECCION;
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
                tarif.Add(new Tarifa
                {

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



        

        public void InsertPrestamo(Prestamo campos)
        {

            prestamo prestamo = new prestamo();

            prestamo.ID_CLIENTE = campos.ID_CLIENTE;
            prestamo.TIPO = campos.TIPO;
            prestamo.MONTO = campos.MONTO;
            prestamo.MONTO_CUOTA = campos.MONTO_CUOTA;
            prestamo.NO_CUOTA = campos.NO_CUOTA;
            prestamo.MONTO_CALCULADO = campos.MONTO_CALCULADO;
            db.prestamo.Add(prestamo);
            db.SaveChanges();


        }
       

        
        








    }
}
