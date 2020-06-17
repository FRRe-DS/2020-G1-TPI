/**
 * Domicilio.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    Calle:{
      type: 'string'
    },
    NroDeCalle:{
      type: 'string'
    },
    Dpto:{
      type: 'string'
    },
    NroDeDpto:{
      type: 'string'
    },
    Piso:{
      type: 'string'
    },
    LocalidadId:{
      type: 'number'
    },
    Localidad:{ //modelo Uno-Muchos
      model: 'Localidades'
    },
    //Relacion
    owner:{
      model:'Paciente',
    }
  },

};

