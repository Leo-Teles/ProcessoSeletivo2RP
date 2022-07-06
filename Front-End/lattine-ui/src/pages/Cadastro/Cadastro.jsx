import React, { useState, useEffect } from "react";

import '../../assets/css/style.css'

import imgCadastro from '../../assets/img/pessoaCadastro.png';
import imgUsuario from '../../assets/img/pessoa.png';
import imgCadeado from '../../assets/img/cadeado.png';
import imgCarta from '../../assets/img/carta.png';

export default function Cadastro() {
    const [nome, setNome] = useState("");
    const [sobrenome, setSobrenome] = useState("");
    const [email, setEmail] = useState("");
    const [senha, setSenha] = useState("");
  

    

    return (

        <div className="blocoTodo">

            <div className="primeiroBloco">

                <div className="teste-div">
                    <h1 className="cadastro">Cadastre-se</h1>
                    <p className="rapidofacil">É rápido e fácil.</p>
                </div>

                <img className="imgLogin" src={imgCadastro} alt="Imagem Cadastro" />
            </div>

            <div className="testeCadastro">
                <form  className="blocoSegundo">


                    <div>

                        <img className="imgUsuario" src={imgUsuario} alt="Imagem Usuário" />
                        <input value={nome} onChange={(campo) =>
                            setNome(campo.target.value)} placeholder="Nome" className="input" />
                    </div>


                    <div>
                        <img className="imgUsuario" src={imgCarta} alt="Imagem Carta" />

                        <input value={email} onChange={(campo) =>
                            setEmail(campo.target.value)} placeholder="E-mail" className="input" />
                    </div>

                    <div>
                        <img className="imgUsuario" src={imgCadeado} alt="Imagem Cadeado" />

                        <input type="password" value={senha} onChange={(campo) =>
                            setSenha(campo.target.value)} placeholder="Senha" className="input" />
                    </div>
                        <button type="submit" className="cadastrar"> Cadastrar </button>

                </form>

            </div>


        </div>
    )
}