/**
 * TipoDeOcupacionDelPaciente.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    ocupacion:{
      type: 'string',
      required: true,
    },
    //Relacion
    ocupacionPacientes:{
      collection:'AntecedenteEpidemiologicos1',
      via:'TipoDeOcupacionDelPaciente'
    }
  },

};

