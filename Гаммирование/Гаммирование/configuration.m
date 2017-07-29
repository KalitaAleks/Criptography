x=-10:0.1:10;                         % �������� ������� � � ��� ���
y=-10:0.1:10;                         %�������� ������� � � ��� ���
[X1, X2]=meshgrid(x, y);              % ������� �:� ��� ����� �� ��������� ��
z = fun_conf(X1,X2);                  % ������� ��� �������� �������
v=[1,4];                              

 figure                               % ������ ��������� 
 mesh(X1,X2,z);
hold on; 
 grid on;
figure                                % ������ ������ �������
contour(X1,X2,z,v);                   
hold on;
grid on;
axis([0 10 0 11]);
 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ������ ������ �����������
d=1         % ��������� ���
A=8         %  � � � ��������� ���������� ����� 
B=9
L=2         % ��������� ����
a=0.5       % ���������� ����
e=0.0003    % ��������� ��������
direction=0; % ������� �����������
last_direction=0; % ������� �����������
while d>e            % ���� ��� ������ �������� ��������� ����
F =fun_conf(A,B)   % ����������� �������� ������� � ��������� �����
F1=fun_conf(A+d,B)   % ��������� �������� ������� � ����� �� ���������� (1,0)
F2=fun_conf(A, B+d)  % ��������� �������� ������� �� ��������� (0,1)
F3=fun_conf(A-d,B)   % ��������� �������� ������� � ����� �� ���������� (-1, 0)
F4=fun_conf(A, B-d)    % ��������� �������� ������� �� ��������� (0,-1)
Fi=min([F,F1,F2,F3,F4]) % �������� ����������� �������
comet(A,B)               % ���������� ����� �� �������
if Fi==F1                % ���� ����������� ����� F1 
     direction=1          % ������ ����������� (1,0)
if last_direction~=direction % ���� ������� ����������� �� ����� �������� ����������� 
    d=1                      % ��� ���������� � ��������� ��������
end
    A=A+d                    %������ ���������� ����� �����
    B=B
    d=d*L % ����������� (��������) ���
  comet(A,B)
end
if Fi==F2                  
    direction=2                   % ������ ����������� (0,1)
    if last_direction~=direction
    d=1
    end
    A=A
    B=B+d
    d=d*L
   comet(A,B)
end
if Fi==F3 %������ ���������� (-1,0)
    direction=3
    if last_direction~=direction
      d=1
    end
    A=A-d
    B=B
    d=d*L
  comet(A,B)
end
if Fi==F4       % ������ ����������� (0,-1)
    direction=4
    if last_direction~=direction
       d=1
    end
    A=A
    B=B-d
    d=d*L
   comet(A,B)
end
if Fi==F                          % ���� ����������� �������� � ������� ����� 
    direction=0                   % �������� � ���
    if last_direction~=direction
    d=1
    end
A=A
B=B
    d=d*a                   % ���������(���������) ��� 
  end
last_direction=direction     % ������� ����������� = �������� �����������
% pause(10)                  % ����� 10 ���. �� ����������� �� ���� ������
                             % ������ �������� ��������� �� ����� � ����� ��������
end                           % ��������� ����
 


    


 
