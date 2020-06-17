/**
 * AntecedenteEpidemoliogicos1.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {

    TipoDeOcupacionDelPaciente:{ //Modelo Uno-Muchos
      model: 'TipoDeOcupacionDelPaciente'
    },
    OtroTipoDeOcupacion:{
      type: 'string'
    },
    TieneVacunaAntiGripal:{
      type: 'boolean',
      defaultsTo: false
    },
    FechaDeVacunacion:{
      type: 'string'
    },
    FechaDeVencimientoDeLaVacuna:{
      type: 'string'
    },
    EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas:{
      type: 'boolean',
      defaultsTo: false
    },
    PaisEnQueEstuvo:{
      type: 'string'
    },
    CiudadDelPaisEnQueEstuvo:{
      type: 'string'
    },
    FechaDeLlegadaAlPaisEnQueEstuvo:{
      type: 'string'
    },
    FechaDeSalidaAlPaisEnQueEstuvo:{
      type: 'string'
    },
    TipoDeTransporteUtilizado:{ //Modelo Uno-Muchos
      model: 'TipoDeTransporteUtilizado'
    },
    FechaDeIngresoAlPais:{
      type: 'string'
    },
    CompaniaDeTransporte:{
      type: 'string'
    },
    ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas:{
      type: 'boolean',
      defaultsTo: false
    },
    DomicilioAjenoEnElQueResidio:{ //Modelo domicilio Uno-Uno ***CORREGIR
      /*collection: 'Domicilio',
      via:'owner'*/
      type:'string'
    },
    FechaDeLlegadaADomicilioAjeno:{
      type: 'string'
    },
    FechaDeSalidaDelDomicilioAjeno:{
      type: 'string'
    },
    //Relacion Uno-Uno
    owner:{
      model:'FormularioParaAnalisis',
      unique: true
    }

  },

};

