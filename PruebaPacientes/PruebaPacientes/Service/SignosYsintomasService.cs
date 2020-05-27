using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class SignosYsintomasService
    {
        DataContext dataContext;

        public SignosYsintomasService(DataContext context)
        {
            dataContext = context;
        }

        public List<SignosYSintomas> GetSignosYsintomas()
        {
            List<SignosYSintomas> ListaSintomasYSingno = new List<SignosYSintomas>();

            SignosYSintomas sys1 = new SignosYSintomas();
            sys1.Artralgias = false;
            sys1.Convulsiones = false;
            sys1.Diarrea = false;
            sys1.DolorAbdominal = false;
            sys1.DolorDeGarganta = false;
            sys1.DolorToracico = true;
            sys1.FiebreMayorA38 = true;
            sys1.InsuficienciaRespiratoria = true;
            sys1.IrritabilidadConfusion = true;
            sys1.MalestarEnGenerl = false;
            sys1.RechazoAlAlimento = false;
            sys1.Taquipnea_Disnea = false;
            sys1.Tos = true;
            sys1.Vomitos = true;
            sys1.Otros = false;
            sys1.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys1);

            SignosYSintomas sys2 = new SignosYSintomas();
            sys2.Artralgias = false;
            sys2.Convulsiones = false;
            sys2.Diarrea = false;
            sys2.DolorAbdominal = false;
            sys2.DolorDeGarganta = false;
            sys2.DolorToracico = false;
            sys2.FiebreMayorA38 = false;
            sys2.InsuficienciaRespiratoria = false;
            sys2.IrritabilidadConfusion = false;
            sys2.MalestarEnGenerl = false;
            sys2.RechazoAlAlimento = false;
            sys2.Taquipnea_Disnea = false;
            sys2.Tos = false;
            sys2.Vomitos = false;
            sys2.Otros = false;
            sys2.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys2);

            SignosYSintomas sys3 = new SignosYSintomas();
            sys3.Artralgias = false;
            sys3.Convulsiones = true;
            sys3.Diarrea = false;
            sys3.DolorAbdominal = false;
            sys3.DolorDeGarganta = true;
            sys3.DolorToracico = false;
            sys3.FiebreMayorA38 = false;
            sys3.InsuficienciaRespiratoria = false;
            sys3.IrritabilidadConfusion = true;
            sys3.MalestarEnGenerl = false;
            sys3.RechazoAlAlimento = false;
            sys3.Taquipnea_Disnea = false;
            sys3.Tos = false;
            sys3.Vomitos = true;
            sys3.Otros = false;
            sys3.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys3);

            SignosYSintomas sys4 = new SignosYSintomas();
            sys4.Artralgias = true;
            sys4.Convulsiones = true;
            sys4.Diarrea = true;
            sys4.DolorAbdominal = true;
            sys4.DolorDeGarganta = false;
            sys4.DolorToracico = false;
            sys4.FiebreMayorA38 = false;
            sys4.InsuficienciaRespiratoria = false;
            sys4.IrritabilidadConfusion = false;
            sys4.MalestarEnGenerl = false;
            sys4.RechazoAlAlimento = false;
            sys4.Taquipnea_Disnea = false;
            sys4.Tos = false;
            sys4.Vomitos = false;
            sys4.Otros = false;
            sys4.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys4);

            SignosYSintomas sys5 = new SignosYSintomas();
            sys5.Artralgias = false;
            sys5.Convulsiones = false;
            sys5.Diarrea = false;
            sys5.DolorAbdominal = false;
            sys5.DolorDeGarganta = false;
            sys5.DolorToracico = false;
            sys5.FiebreMayorA38 = false;
            sys5.InsuficienciaRespiratoria = true;
            sys5.IrritabilidadConfusion = true;
            sys5.MalestarEnGenerl = true;
            sys5.RechazoAlAlimento = true;
            sys5.Taquipnea_Disnea = true;
            sys5.Tos = false;
            sys5.Vomitos = false;
            sys5.Otros = false;
            sys5.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys5);

            SignosYSintomas sys6 = new SignosYSintomas();
            sys6.Artralgias = true;
            sys6.Convulsiones = false;
            sys6.Diarrea = false;
            sys6.DolorAbdominal = true;
            sys6.DolorDeGarganta = false;
            sys6.DolorToracico = false;
            sys6.FiebreMayorA38 = true;
            sys6.InsuficienciaRespiratoria = false;
            sys6.IrritabilidadConfusion = false;
            sys6.MalestarEnGenerl = false;
            sys6.RechazoAlAlimento = false;
            sys6.Taquipnea_Disnea = false;
            sys6.Tos = true;
            sys6.Vomitos = true;
            sys6.Otros = false;
            sys6.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys6);

            SignosYSintomas sys7 = new SignosYSintomas();
            sys7.Artralgias = false;
            sys7.Convulsiones = false;
            sys7.Diarrea = true;
            sys7.DolorAbdominal = false;
            sys7.DolorDeGarganta = false;
            sys7.DolorToracico = true;
            sys7.FiebreMayorA38 = false;
            sys7.InsuficienciaRespiratoria = false;
            sys7.IrritabilidadConfusion = false;
            sys7.MalestarEnGenerl = false;
            sys7.RechazoAlAlimento = true;
            sys7.Taquipnea_Disnea = true;
            sys7.Tos = true;
            sys7.Vomitos = true;
            sys7.Otros = false;
            sys7.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys7);

            SignosYSintomas sys8 = new SignosYSintomas();
            sys8.Artralgias = true;
            sys8.Convulsiones = true;
            sys8.Diarrea = true;
            sys8.DolorAbdominal = true;
            sys8.DolorDeGarganta = true;
            sys8.DolorToracico = true;
            sys8.FiebreMayorA38 = true;
            sys8.InsuficienciaRespiratoria = true;
            sys8.IrritabilidadConfusion = true;
            sys8.MalestarEnGenerl = true;
            sys8.RechazoAlAlimento = true;
            sys8.Taquipnea_Disnea = true;
            sys8.Tos = true;
            sys8.Vomitos = true;
            sys8.Otros = true;
            sys8.OtrosDetalle = "Me voy a morir";
            ListaSintomasYSingno.Add(sys8);

            SignosYSintomas sys9 = new SignosYSintomas();
            sys9.Artralgias = false;
            sys9.Convulsiones = true;
            sys9.Diarrea = false;
            sys9.DolorAbdominal = false;
            sys9.DolorDeGarganta = false;
            sys9.DolorToracico = true;
            sys9.FiebreMayorA38 = false;
            sys9.InsuficienciaRespiratoria = false;
            sys9.IrritabilidadConfusion = false;
            sys9.MalestarEnGenerl = true;
            sys9.RechazoAlAlimento = true;
            sys9.Taquipnea_Disnea = false;
            sys9.Tos = false;
            sys9.Vomitos = false;
            sys9.Otros = false;
            sys9.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys9);

            SignosYSintomas sys10 = new SignosYSintomas();
            sys10.Artralgias = false;
            sys10.Convulsiones = false;
            sys10.Diarrea = false;
            sys10.DolorAbdominal = false;
            sys10.DolorDeGarganta = false;
            sys10.DolorToracico = false;
            sys10.FiebreMayorA38 = false;
            sys10.InsuficienciaRespiratoria = false;
            sys10.IrritabilidadConfusion = false;
            sys10.MalestarEnGenerl = false;
            sys10.RechazoAlAlimento = false;
            sys10.Taquipnea_Disnea = false;
            sys10.Tos = true;
            sys10.Vomitos = true;
            sys10.Otros = false;
            sys10.OtrosDetalle = "";
            ListaSintomasYSingno.Add(sys10);

            return ListaSintomasYSingno;
        }

    }
}
