@echo off

SET dir=%~dp0

call "%dir%..\config\path_config.bat"

%cipher% cae -d -k %cae_key% -i %encoded_file% -o %decoded_file%

pause