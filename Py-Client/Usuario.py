# -*- coding: utf-8 -*-
"""
Created on Mon Oct 28 17:02:41 2019

@author: Alexssander & Flavio
"""

from zeep import Client
import os
os.system('cls' if os.name == 'nt' else 'clear')
#client = Client(wsdl='http://localhost:44383/WebService1.asmx?wsdl')
#client = Client(wsdl='http://localhost:44383/WebService1.asmx')
print('\n')
print('  _   __     ______      ___  ____  ____    ')
print(' | | / /     | ___ \     |  \/  | | \ \ \   ')
print(' | |/ /  __ _| |_/ /_   _| .  . | |  \ \ \  ')
print(' |    \ / _` | ___ \ | | | |\/| | |   > > > ')
print(' | |\  \ (_| | |_/ / |_| | |  | |_|  / / /  ')
print(' \_| \_/\__,_\____/ \__,_\_|  |_(_) /_/_/   ')
print('--------------------------------------------')                                           
print('|                  Cliente                 |')
print('--------------------------------------------')

client = Client(wsdl='http://localhost:44383/WebService1.asmx?wsdl')

#print (ins[0]["cpf"])

while True:
    print('\n')
    print('1) Listar Produtos')
    print('2) Comprar Produtos')  
    print('3) Buscar Produtos')
    print('4) Meus Produtos')
    print('0) Sair')                                         
    print('\n')
    op = input('> ')
#------------------------------Listar Produtos -------------------------------------    
    if op == '1':
        x = [client.service.ObterProdutoPorMarca('todas')]
        x2 = [(x[0]['Produto'])]
        print('\n')
        ins = x2[0]
        i = 0    
        for prod in ins:
            print ('Produto: ',ins[i]["nome"])
            print ('Descrição: ',ins[i]["descricao"]) 
            print ('Categoria: ',ins[i]["categoria"])
            print ('Modelo: ',ins[i]["modelo"])
            print ('Valor: R$ ',ins[i]["valor"])
            disponivel = (ins[i]["quantidade"])
            if disponivel != '0':
                print("Status: Disponivel")
            else:
                print("Status: Indisponivel")
            i = i + 1
            print('\n')
#---------------------------- Comprar Produtos --------------------------------    
    elif op == '2':
        print("operação 2")
#---------------------------- Buscar Produtos ---------------------------------         
    elif op == '3':
        marca = input('Marca > ')
        x = [client.service.ObterProdutoPorMarca(marca)]
        x2 = [(x[0]['Produto'])]
        print('\n')
        ins = x2[0]
        i = 0    
        for prod in ins:
            print ('Produto: ',ins[i]["nome"])
            print ('Descrição: ',ins[i]["descricao"]) 
            print ('Categoria: ',ins[i]["categoria"])
            print ('Modelo: ',ins[i]["modelo"])
            print ('Valor: R$ ',ins[i]["valor"])
            disponivel = (ins[i]["quantidade"])
            if disponivel != '0':
                print("Status: Disponivel")
            else:
                print("Status: Indisponivel")
            i = i + 1
            print('\n')
#---------------------------- Meus Produtos -----------------------------------             
    elif op == '4':
        print("operação 4")
#-------------------------------- Sair ---------------------------------------- 
    elif op == '0':
        break
    else:
        print('Opcao invalida!')

    
    
    