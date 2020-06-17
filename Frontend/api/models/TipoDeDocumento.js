/**
 * TipoDeDocumento.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    documento:{
      type:'string',
      defaultsTo: 'dni'
    },
    //Relacion Muchos-Uno
    pacientes:{
      collection:'Paciente',
      via:'TipoDeDocumento'
    }
  },

};

