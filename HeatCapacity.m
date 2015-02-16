

Kb = 1.38*10^-23;
h = 1.055*10^-34;
v = 3500;
T = 100 * 10^3;
x = @(w) h*w/(Kb*T);
f = @(w) 3*Kb/(2*pi^2*v^3)*(Kb/h)^3*T^3*x(w)^4*exp(x(w))/(exp(x(w)-1))^2;
w = zeros(1000);
u = zeros(1000);
for i = 1:1:1000
   w(i) = i*1000000000*T;
    u(i) = f(w(i));
end
plot(w,u,'b*-');