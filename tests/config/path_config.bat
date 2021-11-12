@echo off

SET app_name=cipher.exe
SET app_subdirectory=..\app\
SET cipher="%~dp0%app_subdirectory%%app_name%"
SET source_file="%dir%..\source.txt"
SET encoded_file="%dir%encoded.txt"
SET decoded_file="%dir%decoded.txt"

SET cae_key=22
SET vig_key=Виженер