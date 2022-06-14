using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLGasto
    {
        MPPGasto oMPPGasto;

        public List<BEGasto> Listar_Gastos(int pAño)
        {
            oMPPGasto = new MPPGasto();
            return oMPPGasto.Listar_Gastos(pAño);
        }

        public List<BEGasto> Filtrar_Gastos_Por_Mes(int pMes, int pAño)
        {
            oMPPGasto = new MPPGasto();
            return oMPPGasto.Filtrar_Gastos_Por_Mes(pMes, pAño);
        }
    
        public bool Operacion_Gasto(BEGasto oBEGasto, int pOperacion)
        {
            oMPPGasto = new MPPGasto();
            return oMPPGasto.Operacion_Gasto(oBEGasto, pOperacion);
        }

        public decimal Total_Gastos(int pAño)
        {
            oMPPGasto = new MPPGasto();
            return oMPPGasto.Total_Gastos(pAño);
        }
        
        public decimal Gasto_Total_Mes(int pMes, int pAño)
        {
            oMPPGasto = new MPPGasto();
            return oMPPGasto.Total_Gastos_Mes(pMes, pAño);
        }

        public Dictionary<string, decimal> Grafico_Gastos(int pAño)
        {
            oMPPGasto = new MPPGasto();
            return oMPPGasto.Grafico_Gastos(pAño);
        }
    }
}
