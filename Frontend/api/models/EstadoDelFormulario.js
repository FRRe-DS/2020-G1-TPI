/**
 * EstadoDelFormulario.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    estado:{
      type:'string',required:true
    },
    //Relacion Uno(estado)-Muchos(formularios)
    formularios:{
      collection:'FormularioParaAnalisis',
      via:'EstadoDelFormulario'
    }

  },

};

