/**
 * TipoDeEntornoDeContacto.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    entorno:{
      type:'string',required:true
    },
    //Relacion
    entornoPacientes:{
      collection:'AntecedenteEpidemiologicos2',
      via:'TipoDeEntornoDeContacto'
    }
  },

};

