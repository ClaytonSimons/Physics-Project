Kb = 1.38*10^-23;
h = 1.055*10^-34;
v = 3500;
T = 100;
DebyeTemp = 375;
gamma = 1;
M = 72.61;
A = 2.57*10^-44;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
TauU = @(w) A*w^4;
iters = 1000;
dw = 200000000000;
w = zeros(iters,1);
u = zeros(iters,1);
Tu = zeros(iters,1);
for i = 1:1:iters
   w(i) = i*dw;
    u(i) = f(w(i));
    Tu(i) = TauU(w(i));
end
%semilogy(w,u,'b*-');hold on;

T = 200;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
TauU = @(w) A*w^4;
w2 = zeros(iters,1);
u2 = zeros(iters,1);
Tu2 = zeros(iters,1);
for i = 1:1:iters
   w2(i) = i*dw;
    u2(i) = f(w2(i));
    Tu2(i) = TauU(w2(i));
end
%semilogy(w,u,'r*-');hold on;
dw3 = 200000000000;
T = 300;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
TauU = @(w) A*w^4;
w3 = zeros(iters,1);
u3 = zeros(iters,1);
Tu3 = zeros(iters,1);
for i = 1:1:iters
   w3(i) = i*dw3;
    u3(i) = f(w3(i));
    Tu3(i) = TauU(w3(i));
end
%start umklapp

[ax,pa,pb] = plotyy(w,u,w,Tu,'semilogy','plot');hold on;
 ylim(ax(2),[0 10^14]);
%ylim(ax(1),[10^-2 10^10]);
%xlim([0 10^14]);
 [ax2,pa2,pb2] = plotyy(w2,u2,w2,Tu2,'semilogy','plot');hold on;
 ylim(ax2(2),[0 10^14]);
 %ylim(ax2(1),[10^-2 10^10]);
 %xlim([0 10^14]);
[ax3,pa3,pb3] = plotyy(w3,u3,w3,Tu3,'semilogy','plot');hold on;
ylim(ax3(2),[0 10^14]);
%ylim(ax3(1),[10^-2 10^10]);
%xlim([0 10^14]);
set([pa,pb],'color','b','marker','.');
set([pa2;pb2],'color','r','marker','.');
set([pa3;pb3],'color','g','marker','.');
% legend([pa;pa2;pa3],'T = 100','T = 200','T = 300');
ylabel(ax3(1),'Rayleigh');
ylabel(ax3(2),'Umklapp');
xlabel(ax3(2),'Frequency w');

%To textfile
fileID = fopen('RayleighData.txt','wt');
fprintf(fileID,'HCT1, HCT2, HCT3, TauT1, TauT2, TauT3 \n');
for i = 1:iters
   fprintf(fileID,'%f, %f, %f, %f, %f, %f \n',u(i),u2(i),u3(i),Tu(i),Tu2(i),Tu3(i)); 
end
fclose(fileID);

% semilogy(w,u,'b*-',w2,u2,'r*-',w3,u3,'g*-')
% legend('T = 100','T = 200','T = 300');hold on;