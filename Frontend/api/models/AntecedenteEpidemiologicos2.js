/**
 * AntecedenteEpidemoliogicos2.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {

    VisitoCentroConCasosPositivosPrevioASintomas:{
      type: 'boolean',
      defaultsTo: false
    },
    NombreDelCentroVisitado:{
      type: 'string'
    },
    CiudadDelCentroVisitado:{
      type: 'string'
    },
    FechaDeLaVisitaAlCentro:{
      type: 'string'
    },
    ContactoConAnimalesPrevioASintomas:{
      type: 'boolean',
      defaultsTo: false
    },
    TipoDeAnimalesConContacto:{ //Modelo Uno-Muchos
      model: 'TipoDeAnimalesConContacto'
    },
    OtroTipoDeContactoConAnimales:{
      type: 'string'
    },
    ContactoConPersonasConIRPrevioASintomas:{
      type: 'boolean',
      defaultsTo: false
    },
    TipoDeEntornoDeContacto:{ //Modelo
      model: 'TipoDeEntornoDeContacto'
    },
    OtroTipoDeEntornoDeContacto:{
      type: 'string'
    },
    ContactoConCasosProbablesOConfirmadosPrevioASintomas:{
      type: 'boolean',
      defaultsTo: false
    },
    ApellidoDelCaso:{
      type: 'string'
    },
    NombreDelCaso:{
      type: 'string'
    },
    DNIDelCaso:{
      type: 'string'
    },
    PaisDelCaso:{
      type: 'string'
    },
    AreaDelCaso:{
      type:'string'
    },
    //Relacion
    owner:{
      model:'FormularioParaAnalisis',
      unique: true
    }

  },

};

