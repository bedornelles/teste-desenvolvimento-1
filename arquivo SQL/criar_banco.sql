create table produto(
	codigo_produto int primary key,
	nome_produto varchar(100) not null,
	check (codigo_produto > 0)
);

create table log_operacoes (
	id serial primary key,
	data_hora timestamp not null default current_timestamp,
	operacao varchar(100) not null,
	codigo_produto int
);

create or replace function function_log_produto()
returns trigger
as $$
begin

	if TG_OP = 'DELETE' then
		insert into log_operacoes (operacao, codigo_produto)
		values (TG_OP, OLD.codigo_produto);	
		return OLD;
	ELSIF TG_OP = 'UPDATE' then
		insert into log_operacoes (operacao, codigo_produto)
		values (TG_OP || ' mudou de ' || OLD.nome_produto || ' para ' || NEW.nome_produto, NEW.codigo_produto);		
		return NEW;
	ELSE
		insert into log_operacoes (operacao, codigo_produto)
		values (TG_OP, NEW.codigo_produto);		
		return NEW;
	END IF;	
end;
$$ language plpgsql;

create trigger trigger_log_produto
after insert or update or delete
on produto
for each row
execute function function_log_produto();