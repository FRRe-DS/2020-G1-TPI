/**
 * FormularioParaAnalisis.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {

    EstadoDelFormulario:{ //modelo Uno-Muchos
      model:'EstadoDelFormulario'
    },
    FechaDeCreacion:{
      type:'string'
    },
    /*Paciente:{ //modelo Uno-Uno
      collection:'Paciente',
      via:'owner'
    },*/
    /*PacienteId:{
      type:'number',
    },*/
    AntecedenteEpidemiologico1:{ //modelo Uno-Uno
      collection:'AntecedenteEpidemiologicos1',
      via:'owner'
    },
    /*AntecedenteEpidemiologico1Id:{ 
      type:'number',
    },*/
    AntecedenteEpidemiologico2:{ //modelo Uno-Uno
      collection:'AntecedenteEpidemiologicos2',
      via:'owner'
    },
    /*AntecedenteEpidemiologico2Id:{ 
      type:'number',
    },*/
    EnfermedadesPreviasComorbilidades:{ //Modelo Uno-Uno
      collection:'EnfermedadesPreviasComorbilidades',
      via:"owner"
    },
    /*EnfermedadesPreviasComorbilidadesId:{
      type:'number',
    },*/ 
    SignosYSintomas:{ //modelo Uno-Uno
      collection:'SignosYSintomas',
      via:"owner"
    },
    /*SignosYSintomasId:{
      type: 'number'
    },*/
    RespuestaMedica:{
      type:'string'
    },

  },

};

