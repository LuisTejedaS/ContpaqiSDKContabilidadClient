using AccountingClient.Core.Schema;
using AccountingClient.Schema;
using SDKCONTPAQNGLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CONTPAQi_HE_ADD.Core.IJournalEntryService" />
    public class ContpaqLegacyJournalEntryProvider : IJournalEntryService
    {


        ///// <summary>
        ///// Gets the journal entry.
        ///// </summary>
        ///// <param name="session">The session.</param>
        ///// <param name="filter">The filter.</param>
        ///// <returns></returns>
        //public List<JournalEntry> GetJournalEntry(Session session, JournalEntryFilterWindowModel filter)
        //{
        //    TSdkSesion sdkSession = session.LegacySession;
        //    ITSdkPoliza tSdkPoliza = new TSdkPoliza();
        //    tSdkPoliza.setSesion(sdkSession);
        //    TSdkTipoPoliza aSdkTipoPoliza = new TSdkTipoPoliza();


        //    List<JournalEntry> journalEntries = new List<JournalEntry>();

        //    DateTime initial = filter.DateRangeFilter.InitialDate;
        //    DateTime final = filter.DateRangeFilter.FinalDate;
        //    string journalEntryType = filter.JournalEntryTypeCode.ToString();
        //    int initialNumber = filter.NumberRangeFilter.InitialNumber;
        //    int finalNumber = filter.NumberRangeFilter.FinalNumber;

        //    tSdkPoliza.consultaPolizasPorSistOrigenRango_buscaListado("11", journalEntryType, initial, final);
        //    var numRegistros = tSdkPoliza.consultaPolizasPorSistOrigenRango_getNumRegistros();

        //    tSdkPoliza.consultaPolizasPorSistOrigenRango_buscaPrimero();
        //    tSdkPoliza.getTipoPoliza(aSdkTipoPoliza);

        //    JournalEntry journalEntry = new JournalEntry()
        //    {
        //        Id = tSdkPoliza.Id,
        //        Type = aSdkTipoPoliza.Nombre,
        //        //Adjust = tSdkPoliza.Ajuste,
        //        AsocReference = tSdkPoliza.ReferenciaAsoc,
        //        Concept = tSdkPoliza.Concepto,
        //        Credits = tSdkPoliza.Abonos,
        //        Date = tSdkPoliza.Fecha,
        //        Debits = tSdkPoliza.Cargos,
        //        DiaryCode = tSdkPoliza.CodigoDiario,
        //        FiscalYear = tSdkPoliza.Ejercicio,
        //        Guid = tSdkPoliza.Guid,
        //        IVAControlNumberOfMovements = tSdkPoliza.NumeroMovtosControlIVA,
        //        Daily = tSdkPoliza.Diario,
        //        LastErrorMessage = tSdkPoliza.UltimoMsjError,
        //        Number = tSdkPoliza.Numero,
        //        NumberOfMovements = tSdkPoliza.NumeroMovtos,
        //        Period = tSdkPoliza.Periodo,
        //        //Printed = tSdkPoliza.Impresa,
        //        User = tSdkPoliza.Usuario
        //    };
        //    journalEntries.Add(journalEntry);

        //    for (int i = 1; i < numRegistros; i++)
        //    {
        //        tSdkPoliza.consultaPolizasPorSistOrigenRango_buscaSiguiente();

        //        journalEntry = new JournalEntry()
        //        {
        //            Id = tSdkPoliza.Id,
        //            Type = aSdkTipoPoliza.Nombre,
        //            //Adjust = tSdkPoliza.Ajuste,
        //            AsocReference = tSdkPoliza.ReferenciaAsoc,
        //            Concept = tSdkPoliza.Concepto,
        //            Credits = tSdkPoliza.Abonos,
        //            Date = tSdkPoliza.Fecha,
        //            Debits = tSdkPoliza.Cargos,
        //            DiaryCode = tSdkPoliza.CodigoDiario,
        //            FiscalYear = tSdkPoliza.Ejercicio,
        //            Guid = tSdkPoliza.Guid,
        //            IVAControlNumberOfMovements = tSdkPoliza.NumeroMovtosControlIVA,
        //            Daily = tSdkPoliza.Diario,
        //            LastErrorMessage = tSdkPoliza.UltimoMsjError,
        //            Number = tSdkPoliza.Numero,
        //            NumberOfMovements = tSdkPoliza.NumeroMovtos,
        //            Period = tSdkPoliza.Periodo,
        //            //Printed = tSdkPoliza.Impresa,
        //            User = tSdkPoliza.Usuario
        //        };
        //        journalEntries.Add(journalEntry);

        //    }

        //    var res = journalEntries.Where(x => x.Number >= initialNumber && x.Number <= finalNumber).ToList();
        //    GetAsociations(session, res);
        //    return res;
        //}

        ///// <summary>
        ///// Gets the journal entry movement.
        ///// </summary>
        ///// <param name="session">The session.</param>
        ///// <param name="filter">The filter.</param>
        ///// <returns></returns>
        //public List<JournalEntryMovement> GetJournalEntryMovement(Session session, JournalEntryMovementFilterWindowModel filter)
        //{
        //    TSdkSesion sdkSession = session.LegacySession;
        //    ITSdkPoliza tSdkPoliza = new TSdkPoliza();
        //    ITSdkPoliza tSdkPolizaDetail = new TSdkPoliza();
        //    TSdkMovimientoPoliza tSdkMovimientoPoliza = new TSdkMovimientoPoliza();
        //    TSdkTipoPoliza aSdkTipoPoliza = new TSdkTipoPoliza();

        //    tSdkPoliza.setSesion(sdkSession); 
        //    tSdkPolizaDetail.setSesion(sdkSession);
        //    tSdkMovimientoPoliza.setSesion(sdkSession);
        //    tSdkMovimientoPoliza.setSdkCuenta(new TSdkCuenta());
       

        //    List<JournalEntry> journalEntries = new List<JournalEntry>();
        //    List<JournalEntryMovement> movs = new List<JournalEntryMovement>();


        //    DateTime initial = filter.DateRangeFilter.InitialDate;
        //    DateTime final = filter.DateRangeFilter.FinalDate;
        //    string journalEntryType = filter.JournalEntryTypeCode.ToString();
        //    int initialNumber = filter.NumberRangeFilter.InitialNumber;
        //    int finalNumber = filter.NumberRangeFilter.FinalNumber;

        //    tSdkPoliza.consultaPolizasPorSistOrigenRango_buscaListado("11", journalEntryType, initial, final);
        //    var numRegistros = tSdkPoliza.consultaPolizasPorSistOrigenRango_getNumRegistros();

        //    tSdkPoliza.consultaPolizasPorSistOrigenRango_buscaPrimero();
        //    tSdkPoliza.getTipoPoliza(aSdkTipoPoliza);

        //    JournalEntry journalEntry = new JournalEntry()
        //    {
        //        Id = tSdkPoliza.Id,
        //        Type = aSdkTipoPoliza.Nombre,
        //        //Adjust = tSdkPoliza.Ajuste,
        //        AsocReference = tSdkPoliza.ReferenciaAsoc,
        //        Concept = tSdkPoliza.Concepto,
        //        Credits = tSdkPoliza.Abonos,
        //        Date = tSdkPoliza.Fecha,
        //        Debits = tSdkPoliza.Cargos,
        //        DiaryCode = tSdkPoliza.CodigoDiario,
        //        FiscalYear = tSdkPoliza.Ejercicio,
        //        Guid = tSdkPoliza.Guid,
        //        IVAControlNumberOfMovements = tSdkPoliza.NumeroMovtosControlIVA,
        //        Daily = tSdkPoliza.Diario,
        //        LastErrorMessage = tSdkPoliza.UltimoMsjError,
        //        Number = tSdkPoliza.Numero,
        //        NumberOfMovements = tSdkPoliza.NumeroMovtos,
        //        Period = tSdkPoliza.Periodo,
        //        //Printed = tSdkPoliza.Impresa,
        //        User = tSdkPoliza.Usuario
        //    };

        //    tSdkPolizaDetail.buscaPorId(journalEntry.Id);

        //    var res = tSdkPolizaDetail.getMovimientoPrimero(tSdkMovimientoPoliza);

        //    if (res > 0)
        //    {
        //        JournalEntryMovement jem = new JournalEntryMovement()
        //        {
        //            Guid = tSdkMovimientoPoliza.Guid,
        //            MovementNumber = tSdkMovimientoPoliza.NumMovto,
        //            Account = tSdkMovimientoPoliza.CodigoCuenta,
        //            //Credits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO ? tSdkMovimientoPoliza.Importe : 0,
        //            //Debits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO ? tSdkMovimientoPoliza.Importe : 0,
        //            //Id = tSdkMovimientoPoliza.Id,
        //            //JournalEntryGuid = journalEntry.Guid,
        //            JournalEntryMovementGuid = tSdkMovimientoPoliza.Guid,
        //        };


        //        movs.Add(jem);

        //        while (tSdkPolizaDetail.getMovimientoSiguiente(tSdkMovimientoPoliza) > 0)
        //        {
        //            jem = new JournalEntryMovement()
        //            {
        //                Guid = tSdkMovimientoPoliza.Guid,
        //                //Date = journalEntry.Date,
        //                //JournalEntryType = journalEntry.Type,
        //                //JournalEntryNumber = journalEntry.Number,
        //                MovementNumber = tSdkMovimientoPoliza.NumMovto,
        //                Account = tSdkMovimientoPoliza.CodigoCuenta,
        //                //Credits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO ? tSdkMovimientoPoliza.Importe : 0,
        //                //Debits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO ? tSdkMovimientoPoliza.Importe : 0,
        //                //Id = tSdkMovimientoPoliza.Id,
        //                //JournalEntryGuid = journalEntry.Guid,
        //                JournalEntryMovementGuid = tSdkMovimientoPoliza.Guid,
        //            };

        //            movs.Add(jem);
        //        }
        //    }


        //    for (int i = 1; i < numRegistros; i++)
        //    {
        //        tSdkPoliza.consultaPolizasPorSistOrigenRango_buscaSiguiente();
        //        tSdkPoliza.getTipoPoliza(aSdkTipoPoliza);

        //        journalEntry = new JournalEntry()
        //          {
        //              Id = tSdkPoliza.Id,
        //              Type = aSdkTipoPoliza.Nombre,
        //              //Adjust = tSdkPoliza.Ajuste,
        //              AsocReference = tSdkPoliza.ReferenciaAsoc,
        //              Concept = tSdkPoliza.Concepto,
        //              Credits = tSdkPoliza.Abonos,
        //              Date = tSdkPoliza.Fecha,
        //              Debits = tSdkPoliza.Cargos,
        //              DiaryCode = tSdkPoliza.CodigoDiario,
        //              FiscalYear = tSdkPoliza.Ejercicio,
        //              Guid = tSdkPoliza.Guid,
        //              IVAControlNumberOfMovements = tSdkPoliza.NumeroMovtosControlIVA,
        //              Daily = tSdkPoliza.Diario,
        //              LastErrorMessage = tSdkPoliza.UltimoMsjError,
        //              Number = tSdkPoliza.Numero,
        //              NumberOfMovements = tSdkPoliza.NumeroMovtos,
        //              Period = tSdkPoliza.Periodo,
        //              //Printed = tSdkPoliza.Impresa,
        //              User = tSdkPoliza.Usuario
        //          };

        //        tSdkPolizaDetail.buscaPorId(journalEntry.Id);
        //        res = tSdkPolizaDetail.getMovimientoPrimero(tSdkMovimientoPoliza);

        //        if (res > 0)
        //        {
        //            JournalEntryMovement jem = new JournalEntryMovement()
        //            {
        //                Guid = tSdkMovimientoPoliza.Guid,
        //                //Date = journalEntry.Date,
        //                //JournalEntryType = journalEntry.Type,
        //                //JournalEntryNumber = journalEntry.Number,
        //                MovementNumber = tSdkMovimientoPoliza.NumMovto,
        //                Account = tSdkMovimientoPoliza.CodigoCuenta,
        //                //Credits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO ? tSdkMovimientoPoliza.Importe : 0,
        //                //Debits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO ? tSdkMovimientoPoliza.Importe : 0,
        //                //Id = tSdkMovimientoPoliza.Id,
        //                //JournalEntryGuid = journalEntry.Guid,
        //                JournalEntryMovementGuid = tSdkMovimientoPoliza.Guid,
        //            };


        //            movs.Add(jem);

        //            while (tSdkPolizaDetail.getMovimientoSiguiente(tSdkMovimientoPoliza) > 0)
        //            {
        //                jem = new JournalEntryMovement()
        //                {
        //                    Guid = tSdkMovimientoPoliza.Guid,
        //                    //Date = journalEntry.Date,
        //                    // JournalEntryType = journalEntry.Type,
        //                    //JournalEntryNumber = journalEntry.Number,
        //                    MovementNumber = tSdkMovimientoPoliza.NumMovto,
        //                    Account = tSdkMovimientoPoliza.CodigoCuenta,
        //                    //Credits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO ? tSdkMovimientoPoliza.Importe : 0,
        //                    //Debits = tSdkMovimientoPoliza.TipoMovto == ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO ? tSdkMovimientoPoliza.Importe : 0,
        //                    //Id = tSdkMovimientoPoliza.Id,
        //                    //JournalEntryGuid = journalEntry.Guid,
        //                    JournalEntryMovementGuid = tSdkMovimientoPoliza.Guid, 
        //                };

        //                movs.Add(jem);
        //            }
        //        }

        //    }            
        //    GetAsociations(session, movs);
        //    return movs;
        //}

        /// <summary>
        /// Creates the journal entry.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="journalEntries">The journal entries.</param>
        public void CreateJournalEntry(Session session,  List<JournalEntry> journalEntries)
        {
            TSdkSesion sdkSession = session.LegacySession;
            ITSdkPoliza tSdkPoliza = new TSdkPoliza();
            TSdkMovimientoPoliza tSdkMovimientoPoliza = new TSdkMovimientoPoliza();

            tSdkPoliza.setSesion(sdkSession);
            tSdkMovimientoPoliza.setSesion(sdkSession);
            tSdkMovimientoPoliza.setSdkCuenta(new TSdkCuenta());

            journalEntries.ForEach(journalEntry =>
            {
                GetTsdkPolFromJournalEntry(tSdkPoliza, tSdkMovimientoPoliza, journalEntry);
                tSdkPoliza.crea();
            });

        }



        public string CreateJE(string user, string pass, string company,
          string jeConcept, string conceptoMov1, string conceptoMov2,
          string accountMov1, decimal totalMovement1, string accountMov2,
          decimal totalMovement2, DateTime fechaPol)
        {
            TSdkSesion sdkSession = new TSdkSesion();
            ITSdkPoliza tSdkPoliza = new TSdkPoliza();
            TSdkMovimientoPoliza tSdkMovPoliza = new TSdkMovimientoPoliza();

            sdkSession.firmaUsuarioParams(user, pass);

            sdkSession.abreEmpresa(company);
            tSdkPoliza.setSesion(sdkSession);
            tSdkMovPoliza.setSesion(sdkSession);



            tSdkPoliza.iniciarInfo();

            tSdkPoliza.Tipo = ETIPOPOLIZA.TIPO_INGRESOS;
            tSdkPoliza.Clase = ECLASEPOLIZA.CLASE_AFECTAR;
            tSdkPoliza.Impresa = 0;
            tSdkPoliza.Fecha = fechaPol;
            tSdkPoliza.Diario = 0;
            tSdkPoliza.SistOrigen = ESISTORIGEN.ORIG_CONTPAQNG;
            tSdkPoliza.Ajuste = 0;
            tSdkPoliza.Concepto = jeConcept;
            tSdkPoliza.Guid = Guid.NewGuid().ToString();

            tSdkMovPoliza.iniciarInfo();

            tSdkMovPoliza.NumMovto = 1;
            tSdkMovPoliza.CodigoCuenta = accountMov1;
            tSdkMovPoliza.TipoMovto = ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO;
            tSdkMovPoliza.Importe = totalMovement1;
            tSdkMovPoliza.ImporteME = 0;
            tSdkMovPoliza.Diario = 0;
            tSdkMovPoliza.SegmentoNegocio = "0";
            tSdkMovPoliza.Concepto = conceptoMov1;
            tSdkMovPoliza.Guid = Guid.NewGuid().ToString();


            tSdkPoliza.agregaMovimiento(tSdkMovPoliza);

            tSdkMovPoliza.iniciarInfo();

            tSdkMovPoliza.NumMovto = 2;
            tSdkMovPoliza.CodigoCuenta = accountMov2;
            tSdkMovPoliza.TipoMovto = ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO;
            tSdkMovPoliza.Importe = totalMovement2;
            tSdkMovPoliza.ImporteME = 0;
            tSdkMovPoliza.Diario = 0;
            tSdkMovPoliza.SegmentoNegocio = "0";
            tSdkMovPoliza.Concepto = conceptoMov2;
            tSdkMovPoliza.Guid = Guid.NewGuid().ToString();


            tSdkPoliza.agregaMovimiento(tSdkMovPoliza);

            tSdkPoliza.crea();

            return "";

        }



        #region private

        private void GetAsociations(Session session, List<JournalEntry> jornalEntries)
        {
            TSdkSesion sdkSession = session.LegacySession;

            TSdkAsocCFDI cfdisdk = new TSdkAsocCFDI();
            cfdisdk.setSesion(sdkSession);

            jornalEntries.ForEach(je =>
            {
                cfdisdk.buscaPorGuid(je.Guid.ToString());
                je.UUIDReferences = cfdisdk.getAsociaciones();

            });
        }

        private void GetAsociations(Session session, List<JournalEntryMovement> journalEntryMovements)
        {
            TSdkSesion sdkSession = session.LegacySession;

            TSdkAsocCFDI cfdisdk = new TSdkAsocCFDI();
            cfdisdk.setSesion(sdkSession);

            journalEntryMovements.ForEach(je =>
            {
                cfdisdk.buscaPorGuid(je.Guid.ToString());
                //je.UUIDReferences = cfdisdk.getAsociaciones();
                //cfdisdk.buscaPorGuid(je.JournalEntryGuid.ToString());
                //je.JournalEntryUUIDReferences = cfdisdk.getAsociaciones();
            });
        }

        /// <summary>
        /// Gets the TSDK pol from journal entry.
        /// </summary>
        /// <param name="tSdkPoliza">The t SDK poliza.</param>
        /// <param name="tSdkMovPoliza">The t SDK mov poliza.</param>
        /// <param name="je">The je.</param>
        private void GetTsdkPolFromJournalEntry(ITSdkPoliza tSdkPoliza, TSdkMovimientoPoliza tSdkMovPoliza,
            JournalEntry je)
        {
            tSdkPoliza.iniciarInfo();
            ESISTORIGEN sourceSystem = GetSourceSystem(je);
            ETIPOPOLIZA tipo = GetJournalEntryType(je);

            tSdkPoliza.Tipo = tipo;
            tSdkPoliza.Clase = je.Affect ? ECLASEPOLIZA.CLASE_AFECTAR : ECLASEPOLIZA.CLASE_SINAFECTAR;
            tSdkPoliza.Impresa = je.Printed ? 1 : 0;
            tSdkPoliza.Fecha = je.Date;
            tSdkPoliza.Diario = je.Daily;
            tSdkPoliza.SistOrigen = sourceSystem;
            tSdkPoliza.Ajuste = je.Adjust ? 1 : 0;
            tSdkPoliza.Concepto = je.Concept;
            tSdkPoliza.Guid = je.Guid.ToString();
            if (je.JournalEntryMovement != null)
            {
                je.JournalEntryMovement.ForEach(movement =>
                {
                    tSdkMovPoliza.iniciarInfo();
                    ETIPOIMPORTEMOVPOLIZA movType = GetJournalEntryMovementType(movement);
                    tSdkMovPoliza.NumMovto = movement.Number;
                    tSdkMovPoliza.CodigoCuenta = movement.Account;
                    tSdkMovPoliza.TipoMovto = movType;
                    tSdkMovPoliza.Importe = movement.Amount;
                    tSdkMovPoliza.ImporteME = movement.AmountFC;
                    tSdkMovPoliza.Diario = movement.JournalEntryMovementDaily;
                    tSdkMovPoliza.SegmentoNegocio = "0";
                    tSdkMovPoliza.Concepto = movement.Concept;
                    tSdkMovPoliza.Guid = movement.Guid.ToString();
                    tSdkPoliza.agregaMovimiento(tSdkMovPoliza);
                });
            }
        }

        /// <summary>
        /// Gets the type of the journal entry movement.
        /// </summary>
        /// <param name="movement">The movement.</param>
        /// <returns></returns>
        private static ETIPOIMPORTEMOVPOLIZA GetJournalEntryMovementType(JournalEntryMovement movement)
        {
            ETIPOIMPORTEMOVPOLIZA movType = ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO;

            if (movement.JournalEntryMovementType == JournalEntryMovementType.DEBITS)
            {
                movType = ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO;
            }

            return movType;
        }

        /// <summary>
        /// Gets the type of the journal entry.
        /// </summary>
        /// <param name="je">The je.</param>
        /// <returns></returns>
        private static ETIPOPOLIZA GetJournalEntryType(JournalEntry je)
        {
            if (!Enum.TryParse(je.Type, out ETIPOPOLIZA tipo))
            {
                tipo = ETIPOPOLIZA.TIPO_INGRESOS;
            }

            return tipo;
        }

        /// <summary>
        /// Gets the source system.
        /// </summary>
        /// <param name="je">The je.</param>
        /// <returns></returns>
        private static ESISTORIGEN GetSourceSystem(JournalEntry je)
        {
            if (!Enum.TryParse(je.SourceSystem, out ESISTORIGEN sourceSystem))
            {
                sourceSystem = ESISTORIGEN.ORIG_CONTPAQNG;
            }

            return sourceSystem;
        }

        #endregion


    }
}
