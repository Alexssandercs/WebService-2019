# -*- coding: utf-8 -*-
"""
Created on Tue Oct 29 15:02:30 2019

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
print('|               Administrador              |')
print('--------------------------------------------')

client = Client(wsdl='http://localhost:44383/WebService1.asmx?wsdl')