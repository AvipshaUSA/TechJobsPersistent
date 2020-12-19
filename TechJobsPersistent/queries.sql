--Part 1
describe jobs;


--Part 2
select Name from  employers where Location = "St. Louis City";


--Part 3

select s.Name, s.Description from skills s, jobs j where s.Id =j.Id order by s.Name asc;

