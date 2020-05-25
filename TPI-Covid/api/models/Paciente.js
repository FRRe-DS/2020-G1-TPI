/**
 * Paciente.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {

    dni:{type: 'number', unique: true, allowNull: false},
    apellido:{type: 'string',allowNull:false},
    nombre:{type: 'string',allowNull:false},
    fechanac:{type: 'number',allowNull:false},
    edad:{type: 'number',allowNull:false},
    sexo:{type: 'string',allowNull:false},
    email:{type: 'string',allowNull:false},
    telefono:{type: 'number',allowNull:false},
    otros:{type: 'json'}


  },
  datastore:'mongodb',

};

