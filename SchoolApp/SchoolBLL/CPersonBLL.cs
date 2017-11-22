using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolEntities;
using SchoolDAL;

namespace SchoolBLL
{
    public class CPersonBLL
    {
        CPersonDAL personDAL = new CPersonDAL();

        public List<CPerson> ListarBLL()
        {
            return personDAL.Listar();
        }

        public CPerson MostrarPersonaBLL(int ID)
        {
            return personDAL.MostrarPersona(ID);
        }

        public Boolean InsertarPersonaBLL(CPerson per)
        {
            if (personDAL.InsertarPersona(per) > 0)
                return true;
            else
                return false;
        }

        public Boolean ModificarPersonaBLL(CPerson per)
        {
            if (personDAL.ModificarPersona(per) > 0)
                return true;
            else
                return false;
        }
    }
}
