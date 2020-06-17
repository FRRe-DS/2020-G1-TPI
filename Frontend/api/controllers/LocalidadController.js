/**
 * LocalidadController
 *
 * @description :: Server-side actions for handling incoming requests.
 * @help        :: See https://sailsjs.com/docs/concepts/actions
 */

module.exports = {
    list: async function(req,res){


        let localidad = await Localidades.find()
    
        return res.status(200).json(localidad)
      }

};

