import numpy as np
import matplotlib.pyplot as plt

# Definiáljuk a három pontot: P0, P1, P2
P0 = np.array([0, 0])  # Kezdő pont
P1 = np.array([1, 2])  # Irányító pont
P2 = np.array([2, 0])  # Végpont

# A Bezier-görbe egyenlete
def bezier_curve(t, P0, P1, P2):
    return (1 - t)**2 * P0 + 2 * (1 - t) * t * P1 + t**2 * P2

# T-értékek, amik mentén kiszámoljuk a görbét
t_values = np.linspace(0, 1, 100)
curve_points = np.array([bezier_curve(t, P0, P1, P2) for t in t_values])

# Ábrázoljuk a görbét és a pontokat
plt.plot(curve_points[:, 0], curve_points[:, 1], label="Bezier-görbe")
plt.scatter([P0[0], P1[0], P2[0]], [P0[1], P1[1], P2[1]], color='red', label="Pontok (P0, P1, P2)")
plt.text(P0[0], P0[1], 'P0', fontsize=12, ha='right')
plt.text(P1[0], P1[1], 'P1', fontsize=12, ha='right')
plt.text(P2[0], P2[1], 'P2', fontsize=12, ha='right')

# Cím és címkék
plt.title("Másodfokú Bezier-görbe")
plt.xlabel("x")
plt.ylabel("y")
plt.legend()

# Ábra megjelenítése
plt.grid(True)
plt.show()
