

Kb = 1.38*10^-23;
h = 1.055*10^-34;
v = 3500;
T = 100;
DebyeTemp = 375;
gamma = 1;
M = 72.61;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
TauU = @(w) h*gamma^2/(M*v^2*DebyeTemp)*w^2*T*exp(-DebyeTemp/(3*T));
iters = 1000;
dw = 200000000000;
w = zeros(iters);
u = zeros(iters);
Ty = zeros(iters);
for i = 1:1:iters
   w(i) = i*dw;
    u(i) = f(w(i));
    Tu(i) = TauU(w(i));
end
%semilogy(w,u,'b*-');hold on;

T = 200;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
TauU = @(w) h*gamma^2/(M*v^2*DebyeTemp)*w^2*T*exp(-DebyeTemp/(3*T));
w2 = zeros(iters);
u2 = zeros(iters);
Ty = zeros(iters);
for i = 1:1:iters
   w2(i) = i*dw;
    u2(i) = f(w(i));
    Tu2(i) = TauU(w(i));
end
%semilogy(w,u,'r*-');hold on;

T = 300;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
TauU = @(w) h*gamma^2/(M*v^2*DebyeTemp)*w^2*T*exp(-DebyeTemp/(3*T));
w3 = zeros(iters);
u3 = zeros(iters);
Ty = zeros(iters);
for i = 1:1:iters
   w3(i) = i*dw;
    u3(i) = f(w(i));
    Tu3(i) = TauU(w(i));
end
%start umklapp

[ax,pa,pb] = plotyy(w,u,w,Tu,'semilogy','plot');ylim(ax(2),[0 10^-17]);ylim(ax(1),[10^-2 10^10]);xlim([0 10^14]);hold on;
[ax2,pa2,pb2] = plotyy(w2,u2,w2,Tu2,'semilogy','plot');ylim(ax2(2),[0 10^-17]);ylim(ax2(1),[10^-2 10^10]);xlim([0 10^14]);hold on;
[ax3,pa3,pb3] = plotyy(w3,u3,w3,Tu3,'semilogy','plot');ylim(ax3(2),[0 10^-17]);ylim(ax3(1),[10^-2 10^10]);xlim([0 10^14]);hold on;
set([pa,pb],'color','b','marker','.');
set([pa2;pb2],'color','r','marker','.');
set([pa3;pb3],'color','g','marker','.');
legend([pa;pa2;pa3],'T = 100','T = 200','T = 300');
ylabel(ax(1),'HeatCapacity');
ylabel(ax(2),'Umklapp');
xlabel(ax(2),'Frequency w');

% semilogy(w,u,'b*-',w2,u2,'r*-',w3,u3,'g*-')
% legend('T = 100','T = 200','T = 300');hold on;