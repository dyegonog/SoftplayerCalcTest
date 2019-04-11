﻿using SoftplayerCalcTest.Aplicacao._Base;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class Juros : CommandHandler<JurosCommandBase, NewResourceResponse>
    {
        public NewResourceResponse Executar(JurosCommandBase cmd)
        {
            return NewResourceResponse.CreateSuccess(cmd.Calcular());
        }
    }
}