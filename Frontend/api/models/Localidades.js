/**
 * Localidad.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    nombre:{
      type:'string',
      required:true
    },
    /*ProvinciaId:{
      type:'number',
    },*/
    Provincia:{ //Modelo Uno-Uno
      model:'Provincias',
    },
    CodigoPostal:{
      type:'string',
    },
    //Relacion
    domicilios:{
      collection:'Domicilio',
      via:'Localidad'
    }
  },

};

