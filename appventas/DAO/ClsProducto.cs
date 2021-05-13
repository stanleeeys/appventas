using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsProducto
    {
        public List<tb_producto> cargarDatosProducto()
        {

            List<tb_producto> Lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_producto.ToList();

            }
            return Lista;
        }

        public void SaveDatosProducto(tb_producto user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {


                    tb_producto userListProducto = new tb_producto();

                    userListProducto.nombreProducto = user.nombreProducto;
                    userListProducto.precioProducto = user.precioProducto;
                    userListProducto.estadoProducto = user.estadoProducto;
                    db.tb_producto.Add(userListProducto);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }



        public void DeleteProducto(int iD)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_producto userListProducto = db.tb_producto.Where(x => x.idProducto == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_producto.Remove(userListProducto);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void updateProducto(tb_producto user)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = Convert.ToInt32(user.idProducto);
                    tb_producto userListProducto = db.tb_producto.Where(x => x.idProducto == update).Select(x => x).FirstOrDefault();
                    userListProducto.nombreProducto = user.nombreProducto;
                    userListProducto.precioProducto = user.precioProducto;
                    userListProducto.estadoProducto = user.estadoProducto;
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
