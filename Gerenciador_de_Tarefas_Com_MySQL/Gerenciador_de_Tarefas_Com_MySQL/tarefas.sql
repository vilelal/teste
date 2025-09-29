
CREATE DATABASE IF NOT EXISTS gerenciador_tarefas;
USE Gerenciador_tarefas;

DROP TABLE IF EXISTS Tarefas;


CREATE TABLE Tarefas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_hora DATETIME,
    nome_tar CHAR(100) NOT NULL,
    descricao_tar CHAR(255) NOT NULL,
    status_tar ENUM('Pendente', 'Atrasada', 'Conclu�da') NOT NULL
);

INSERT INTO Tarefas (data_hora, nome_tar, descricao_tar, status_tar) VALUES ('2025-06-01 00:00:00', "Come�o das tarefas", "Descri��o da tarefa inicial", 'Conclu�da');
INSERT INTO Tarefas (data_hora, nome_tar, descricao_tar, status_tar) VALUES ('2025-12-20 00:00:00', "�ltima tarefas", "Descri��o da tarefa Final", 'Pendente');