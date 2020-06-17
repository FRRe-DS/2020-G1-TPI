/**
 * SignosYSintomasController
 *
 * @description :: Server-side actions for handling incoming requests.
 * @help        :: See https://sailsjs.com/docs/concepts/actions
 */

module.exports = {
    store: async function(req,res){
        let SignosYSintomas = {
            FiebreMayorA38: req.body.fiebre,
            Taquipnea_Disnea: req.body.taquipneaDisnea,
            Diarrea: req.body.diarrea,
            Artralgias: req.body.artralgias,
            MalestarEnGenerl: req.body.malestarGeneral,
            Tos: req.body.tos,
            Vomitos: req.body.vomitos,
            DolorDeGarganta: req.body.dolorGarganta,
            InsuficienciaRespiratoria: req.body.InsuficienciaRespiratoria,
            DolorAbdominal: req.body.dolorAbdominal,
            DolorToracico: req.body.dolorToracico,
            RechazoAlAlimento: req.body.rechazoAlimento,
            IrritabilidadConfusion: req.body.irritabilidadConfusion,
            Convulsiones: req.body.convulsiones,
            OtrosDetalle: req.body.otroStextoma,
          }

        let formulario10 = await SignosYSintomas.create(SignosYSintomas).fetch()
      
        return res.status(201).json(formulario10)
    }

};

