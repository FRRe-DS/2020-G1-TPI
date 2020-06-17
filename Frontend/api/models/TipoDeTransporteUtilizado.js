/**
 * TipoDeTransporteUtilizado.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    transporte:{
      type: 'string',
      required: true,
    },
    //Relacion
    transportePacientes:{
      collection: 'AntecedenteEpidemiologicos1',
      via:'TipoDeTransporteUtilizado'
    }
  },

};

