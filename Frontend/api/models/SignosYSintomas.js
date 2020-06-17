/**
 * SignosYSintomas.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    FiebreMayorA38:{
      type: 'boolean',
      defaultsTo: false,
    },
    Taquipnea_Disnea:{
      type: 'boolean',
      defaultsTo: false,
    },
    Diarrea:{
      type: 'boolean',
      defaultsTo: false
    },
    Artralgias:{
      type: 'boolean',
      defaultsTo: false
    },
    MalestarEnGenerl:{
      type: 'boolean',
      defaultsTo: false
    },
    Tos:{
      type: 'boolean',
      defaultsTo: false
    },
    Vomitos:{
      type: 'boolean',
      defaultsTo: false
    },
    DolorDeGarganta:{
      type: 'boolean',
      defaultsTo: false
    },
    InsuficienciaRespiratoria:{
      type: 'boolean',
      defaultsTo: false
    },
    DolorAbdominal:{
      type: 'boolean',
      defaultsTo: false
    },
    DolorToracico:{
      type: 'boolean',
      defaultsTo: false
    },
    RechazoAlAlimento:{
      type: 'boolean',
      defaultsTo: false
    },
    IrritabilidadConfusion:{
      type: 'boolean',
      defaultsTo: false
    },
    Convulsiones:{
      type: 'boolean',
      defaultsTo: false
    },
    Otros:{
      type: 'boolean',
      defaultsTo: false
    },
    OtrosDetalle:{
      type: 'string'
    },
    //Relacion
    owner:{
      model:'FormularioParaAnalisis',
      unique:true
    }
  },

};

