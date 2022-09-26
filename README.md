# DiffEqA

Numerical integrator for differential equations for a pendulum:
$$\ddot \theta = - \frac{g}{L} \sin(\theta).$$
To simulate, we write this as two first order ODEs.
$$\dot \theta = \omega,$$
$$\dot \omega = - \frac{g}{L} \sin(\theta).$$
