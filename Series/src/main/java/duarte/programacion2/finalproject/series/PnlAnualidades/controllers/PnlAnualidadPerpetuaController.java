/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package duarte.programacion2.finalproject.series.PnlAnualidades.controllers;

import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadPerpetua;
import duarte.programacion2.finalproject.series.PnlAnualidades.core.Anualidades;
import java.awt.Color;
import java.awt.Event;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.text.DecimalFormat;

/**
 *
 * @author dell
 */
public class PnlAnualidadPerpetuaController {

    private final PnlAnualidadPerpetua anualidadPerpetua;
    private DecimalFormat format;

    public PnlAnualidadPerpetuaController(PnlAnualidadPerpetua anualidadPerpetua) {
        this.anualidadPerpetua = anualidadPerpetua;
        initComponent();
    }

    private void initComponent() {
        format = new DecimalFormat("#.##");

        anualidadPerpetua.getTxtValor().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadPerpetua.getTxtValor().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadPerpetua.getTxtTasa().addKeyListener(new KeyAdapter() {

            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadPerpetua.getTxtTasa().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadPerpetua.getTxtValor().addFocusListener(new FocusAdapter() {

            @Override
            public void focusGained(FocusEvent e) {
                anualidadPerpetua.getTxtValor().setText("");
                anualidadPerpetua.getTxtValor().setForeground(Color.BLACK);

                anualidadPerpetua.getFrmtResultado().setText("NaN");
                anualidadPerpetua.getFrmtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadPerpetua.getTxtValor().getText().isBlank()) {
                    return;
                }
                anualidadPerpetua.getTxtValor().setText("Digite el Valor Presente");
                anualidadPerpetua.getTxtValor().setForeground(Color.GRAY);
            }
        });

        anualidadPerpetua.getTxtTasa().addFocusListener(new FocusAdapter() {

            @Override
            public void focusGained(FocusEvent e) {
                anualidadPerpetua.getTxtTasa().setText("");
                anualidadPerpetua.getTxtTasa().setForeground(Color.BLACK);

                anualidadPerpetua.getFrmtResultado().setText("NaN");
                anualidadPerpetua.getFrmtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadPerpetua.getTxtTasa().getText().isBlank()) {
                    return;
                }
                anualidadPerpetua.getTxtTasa().setText("Digite la Tasa");
                anualidadPerpetua.getTxtTasa().setForeground(Color.GRAY);
            }
        });

    }

    private void CalcularAnualidadActionPerformed() {

        if (anualidadPerpetua.getTxtValor().getText().isBlank() || anualidadPerpetua.getTxtTasa().getText().isBlank()) {
            anualidadPerpetua.getFrmtResultado().setText("NaN");
            anualidadPerpetua.getFrmtResultado().setForeground(Color.GRAY);
            return;
        }

        try {
            anualidadPerpetua.getFrmtResultado().setForeground(Color.BLACK);
            anualidadPerpetua.getFrmtResultado().setText(format.format(Anualidades.perpetuaAnualidad(
                    Float.parseFloat(anualidadPerpetua.getTxtValor().getText()), Float.parseFloat(anualidadPerpetua.getTxtTasa().getText()))));

        } catch (NumberFormatException e) {
            //Nothing
        }

    }

}
