/**
 * FormularioParaAnalisisController
 *
 * @description :: Server-side actions for handling incoming requests.
 * @help        :: See https://sailsjs.com/docs/concepts/actions
 */

module.exports = {
  store: async function(req,res){
      /*let paciente = {
        Nombre: req.body.nombre,
        Apellido: req.body.apellido,
        DNI: req.body.dni,
        FechaDeNacimiento: req.body.fechaNacimiento,
        Sexo: req.body.sexo,
        Correo: req.body.email,
        Telefono: req.body.telefono,
      }*/
      let domicilio = {
        Direccion: req.body.direccion,
      }
      /*let localidad = {
        Localidad: req.body.localidad,
        CodigoPostal: req.body.cp
      }
      let provincia = {
        Provincia: req.body.provincia
      }

      let EstadoDelFormulario = 0

      let FechaDeCreacion = new Date()

      let AntecEpi1 = {
        TieneVacunaAntigripal: req.body.antigripal,
        FechaDeVacunacion: req.body.fechaAntigripal,
        EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas: req.body.SiNo,
        PaisEnQueEstuvo: req.body.PaisCiudad,
        CiudadDelPaisEnQueEstuvo: req.body.PaisCiudad,
        FechaDeLlegadaAlPaisEnQueEstuvo: req.body.fechaPaisDesde,
        FechaDeSalidaAlPaisEnQueEstuvo: req.body.fechaPaisHasta,
        FechaDeIngresoAlPais: req.body.fechaIngreso,
        CompaniaDeTransporte: req.body.Compania,
        ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas: req.body.answer,
        FechaDeLlegadaADomicilioAjeno: req.body.fechaDesde,
        FechaDeSalidaDelDomicilioAjeno: req.body.fechaHasta,
      }

      let AntecEpi1_Ocupacion = req.body.Ocupacion

      let AntecEpi1_Transporte = req.body.opcionViaje

      let AntecEpi2 = {
        PresentaEnfermedadesComorbilidades: req.body.Presenta,
        InmunoSupresionCongenitaOAdquirida: req.body.inmunosupresiónCongenita,
        Diabetes: req.body.diabetes,
        Obesidad: req.body.obesidad,
        Embarazo: req.body.embarazo,
        Puerperio: req.body.puerperio,
        Prematuridad: req.body.prematernidad,
        SemanasDePrematuridad: req.body.semanasPrematernidad,
        BajoPesoAlNacer: req.body.gramosAlNacer,
        CantidadPesoAlNacer: req.body.gramosAlNacerpeso,
        EnfermedadNeurologica: req.body.enfNeurologica,
        EnfermedadHepatica: req.body.enfHepatica,
        EnfermedadRenalCronica: req.body.enfRenal,
        HipertensionArterial: req.body.hipertensionArterial,
        EnfermedadOncologica: req.body.enfOncológica,
        BronquitisPrevia: req.body.bronquiolitisPrevia,
        NAC_Previa: req.body.nacPrevia,
        EPOC: req.body.epoc,
        Asma: req.body.asma,
        Tuberculosis: req.body.tuberculosis,
        Fumador: req.body.fumador,
        NingunaDeLasAnteriores: req.body.ninguna,
        OtrasDetalle: req.body.otraEnfermedad,
      }

      let SignosYSintomas = {
        FiebreMayorA38: req.body.fiebre,
        Taquipnea_Disnea: req.body.taquipneaDisnea,
        Diarrea: req.body.diarrea,
        Artralgias: req.body.artralgias,
        MalestarEnGenerl: req.body.malestarGeneral,
        Tos: req.body.tos,
        Vomitos: req.body.vomitos,
        DolorDeGarganta: req.body.dolorGarganta,
        InsuficienciaRespiratoria: req.body.InsuficienciaRespiratoria,
        DolorAbdominal: req.body.dolorAbdominal,
        DolorToracico: req.body.dolorToracico,
        RechazoAlAlimento: req.body.rechazoAlimento,
        IrritabilidadConfusion: req.body.irritabilidadConfusion,
        Convulsiones: req.body.convulsiones,
        OtrosDetalle: req.body.otroStextoma,
      }*/

      
      let formulario1 = await Domicilio.create(domicilio).fetch()
      /*let formulario2 = await Localidad.create(localidad).fetch()
      let formulario3 = await Provincia.create(provincia).fetch()
      let formulario4 = await EstadoDelFormulario.create(EstadoDelFormulario).fetch()
      let formulario5 = await FormularioParaAnalisis.create(FechaDeCreacion).fetch()
      let formulario6 = await AntecedenteEpidemiologicos1.create(AntecEpi1).fetch()
      let formulario7 = await TipoDeOcupacionDelPaciente.create(AntecEpi1_Ocupacion).fetch()
      let formulario8 = await TipoDeTransporteUtilizado.create(AntecEpi1_Transporte).fetch()
      let formulario9 = await AntecedenteEpidemiologicos2.create(AntecEpi2).fetch()
      let formulario10 = await SignosYSintomas.create(SignosYSintomas).fetch()*/
      
      return res.status(201).json(formulario1)
      
  },
};

