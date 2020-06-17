/**
 * TipoDeAnimalesConContacto.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    animales:{
      type:'string',
      required:true
    },
    //Relacion
    animalesPacientes:{
      collection:'AntecedenteEpidemiologicos2',
      via:'TipoDeAnimalesConContacto'
    }
  },

};

