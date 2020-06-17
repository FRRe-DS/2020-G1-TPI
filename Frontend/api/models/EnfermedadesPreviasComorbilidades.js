/**
 * EnfermedadesPreviasComorbilidades.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {
    PresentaEnfermedadesComorbilidades:{
      type: 'boolean',
      defaultsTo: false
    },
    InmunoSupresionCongenitaOAdquirida:{
      type: 'boolean',
      defaultsTo: false
    },
    Diabetes:{
      type: 'boolean',
      defaultsTo: false
    },
    Obesidad:{
      type: 'boolean',
      defaultsTo: false
    },
    Embarazo:{
      type: 'boolean',
      defaultsTo: false
    },
    Puerperio:{
      type: 'boolean',
      defaultsTo: false
    },
    Prematuridad:{
      type: 'boolean',
      defaultsTo: false
    },
    SemanasDePrematuridad:{
      type: 'string'
    },
    BajoPesoAlNacer:{
      type: 'boolean',
      defaultsTo: false
    },
    CantidadPesoAlNacer:{
      type: 'string'
    },
    EnfermedadNeurologica:{
      type: 'boolean',
      defaultsTo: false
    },
    EnfermedadHepatica:{
      type: 'boolean',
      defaultsTo: false
    },
    EnfermedadRenalCronica:{
      type: 'boolean',
      defaultsTo: false
    },
    HipertensionArterial:{
      type: 'boolean',
      defaultsTo: false
    },
    EnfermedadOncologica:{
      type: 'boolean',
      defaultsTo: false
    },
    BronquitisPrevia:{
      type: 'boolean',
      defaultsTo: false
    },
    NAC_Previa:{
      type: 'boolean',
      defaultsTo: false
    },
    EPOC:{
      type: 'boolean',
      defaultsTo: false
    },
    Asma:{
      type: 'boolean',
      defaultsTo: false
    },
    Tuberculosis:{
      type: 'boolean',
      defaultsTo: false
    },
    Fumador:{
      type: 'boolean',
      defaultsTo: false
    },
    NingunaDeLasAnteriores:{
      type: 'boolean',
      defaultsTo: false
    },
    Otras:{
      type: 'boolean',
      defaultsTo: false
    },
    OtrasDetalle:{
      type: 'string'
    },
    //Relacion
    owner:{
      model:'FormularioParaAnalisis',
      unique:true
    }
  },

};

