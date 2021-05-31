/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package duarte.programacion2.finalproject.series.PnlAnualidades.core;

/**
 *
 * @author dell
 */
public class Anualidades {

    public static float anticipadaValorFuturoTasaAnual(float i, float f, float n, float m) {
        float a = 0;
        i = i / 100;

        if (m == 1) {

            a = (f * (float) Math.pow(1 + i, -n)) / (1 + (((float) Math.pow(1 + i, n - 1) - 1) / (i * (float) Math.pow(1 + i, n - 1))));

        } else if (m > 1) {

            float raiz = 1 / m;

            float ip = (float) Math.pow((1 + i), raiz) - 1;

            a = (f * (float) Math.pow(1 + ip, -n)) / (1 + (((float) Math.pow(1 + ip, n - 1) - 1) / (ip * (float) Math.pow(1 + ip, n - 1))));
        }

        return a;
    }

    public static float anticipadaValorFuturoTasaPeriodica(float ip, float f, float n, float m1, float m2) {

        float a = 0;

        if (m1 != m2 && m2 != 1) {

            float raiz = 1 / m2;

            float ip1 = ip / 100;

            float ip2 = (float) Math.pow((float) Math.pow(1 + ip1, m1), raiz) - 1;

            a = (f * (float) Math.pow(1 + ip2, -n)) / (1 + (((float) Math.pow(1 + ip2, n - 1) - 1) / (ip2 * (float) Math.pow(1 + ip2, n - 1))));

        } else if (m1 == m2) {

            ip = ip / 100;

            a = (f * (float) Math.pow(1 + ip, -n)) / (1 + (((float) Math.pow(1 + ip, n - 1) - 1) / (ip * (float) Math.pow(1 + ip, n - 1))));

        } else if (m2 == 1) {

            ip = ip / 100;

            float i = (float) Math.pow(ip + 1, m1) - 1;

            a = (f * (float) Math.pow(1 + i, -n)) / (1 + (((float) Math.pow(1 + i, n - 1) - 1) / (i * (float) Math.pow(1 + i, n - 1))));
        }

        return a;
    }

    public static float anticipadaValorPresenteTasaAnual(float i, float p, float n, float m) {
        float a = 0;
        i = i / 100;

        if (m == 1) {

            a = p / (1 + (((float) Math.pow(1 + i, n - 1) - 1) / (i * (float) Math.pow(1 + i, n - 1))));

        } else if (m > 1) {

            float raiz = 1 / m;

            float ip = (float) Math.pow((1 + i), raiz) - 1;

            a = p / (1 + (((float) Math.pow(1 + ip, n - 1) - 1) / (ip * (float) Math.pow(1 + ip, n - 1))));
        }

        return a;
    }

    public static float anticipadaValorPresenteTasaPeriodica(float ip, float p, float n, float m1, float m2) {

        float a = 0;

        if (m1 != m2 && m2 != 1) {

            float raiz = 1 / m2;

            float ip1 = ip / 100;

            float ip2 = (float) Math.pow((float) Math.pow(1 + ip1, m1), raiz) - 1;

            a = p / (1 + (((float) Math.pow(1 + ip2, n - 1) - 1) / (ip2 * (float) Math.pow(1 + ip2, n - 1))));

        } else if (m1 == m2) {

            ip = ip / 100;

            a = p / (1 + (((float) Math.pow(1 + ip, n - 1) - 1) / (ip * (float) Math.pow(1 + ip, n - 1))));

        } else if (m2 == 1) {

            ip = ip / 100;
            float i = (float) Math.pow(ip + 1, m1) - 1;

            a = p / (1 + (((float) Math.pow(1 + i, n - 1) - 1) / (i * (float) Math.pow(1 + i, n - 1))));
        }

        return a;
    }

    public static float ordinariaValorFuturoTasaAnual(float i, float f, float n, float m) {
        float a = 0;
        i = i / 100;

        if (m == 1) {

            a = f * (i / (((float) Math.pow(1 + i, n)) - 1));

        } else if (m > 1) {

            float raiz = 1 / m;

            float ip = (float) Math.pow((1 + i), raiz) - 1;

            a = f * (ip / (((float) Math.pow(1 + ip, n)) - 1));
        }

        return a;
    }

    public static float ordinariaValorFuturoTasaPeriodica(float ip, float f, float n, float m1, float m2) {
        float a = 0;
        if (m1 != m2 && m2 != 1) {

            float raiz = 1 / m2;

            float ip1 = ip / 100;

            float ip2 = (float) Math.pow((float) Math.pow(1 + ip1, m1), raiz) - 1;

            a = f * (ip2 / (((float) Math.pow(1 + ip2, n)) - 1));

        } else if (m1 == m2) {

            ip = ip / 100;

            a = f * (ip / (((float) Math.pow(1 + ip, n)) - 1));

        } else if (m2 == 1) {

            ip = ip / 100;

            float i = (float) Math.pow(ip + 1, m1) - 1;

            a = f * (i / (((float) Math.pow(1 + i, n)) - 1));
        }

        return a;
    }

    public static float ordinariaValorPresenteTasaAnual(float i, float p, float n, float m) {

        float a = 0;
        i = i / 100;

        if (m == 1) {

            a = p * (i * (float) (Math.pow((1 + i), n)) / (((float) Math.pow(1 + i, n)) - 1));

        } else if (m > 1) {

            float raiz = 1 / m;

            float ip = (float) Math.pow((1 + i), raiz) - 1;

            a = p * (ip * (float) (Math.pow((1 + ip), n)) / (((float) Math.pow(1 + ip, n)) - 1));
        }

        return a;
    }

    public static float ordinariaValorPresenteTasaPeriodica(float ip, float p, float n, float m1, float m2) {
        float a = 0;
        if (m1 != m2 && m2 != 1) {

            float raiz = 1 / m2;

            float ip1 = ip / 100;

            float ip2 = (float) Math.pow((float) Math.pow(1 + ip1, m1), raiz) - 1;

            a = p * (ip2 * (float) (Math.pow((1 + ip2), n)) / (((float) Math.pow(1 + ip2, n)) - 1));

        } else if (m1 == m2) {

            ip = ip / 100;

            a = p * (ip * (float) (Math.pow((1 + ip), n)) / (((float) Math.pow(1 + ip, n)) - 1));

        } else if (m2 == 1) {

            ip = ip / 100;

            float i = (float) Math.pow(ip + 1, m1) - 1;

            a = p * (i * (float) (Math.pow((1 + i), n)) / (((float) Math.pow(1 + i, n)) - 1));
        }

        return a;
    }

    public static float perpetuaPresente(float a, float i) {
        i /= 100;
        return (a / i);
    }

    public static float perpetuaAnualidad(float p, float i) {
        i /= 100;
        return (p * i);
    }

}
