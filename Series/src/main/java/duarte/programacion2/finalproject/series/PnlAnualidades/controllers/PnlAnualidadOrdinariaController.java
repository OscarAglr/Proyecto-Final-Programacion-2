/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package duarte.programacion2.finalproject.series.PnlAnualidades.controllers;

import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadTemplate;
import duarte.programacion2.finalproject.series.PnlAnualidades.core.Anualidades;
import java.awt.Color;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.text.DecimalFormat;
import javax.swing.DefaultComboBoxModel;

/**
 *
 * @author dell
 */
public class PnlAnualidadOrdinariaController {

    private final PnlAnualidadTemplate anualidadOrdinaria;
    private DefaultComboBoxModel cmbTipoPeriodicaModel;
    private DefaultComboBoxModel cmbPeriodosModel;
    private final String[] tipoDeTasa = {"BIMESTRAL", "TRIMESTRAL", "CUATRIMESTRAL", "SEMESTRAL", "MENSUAL"};
    private final String[] periodos = {"BIMESTRES", "TRIMESTRES", "CUATRIMESTRES", "SEMESTRES", "MENSES", "AÑOS"};

    private DecimalFormat format;

    public PnlAnualidadOrdinariaController(PnlAnualidadTemplate anualidadOrdinaria) {
        this.anualidadOrdinaria = anualidadOrdinaria;
        initComponent();
    }

    private void initComponent() {

        cmbTipoPeriodicaModel = new DefaultComboBoxModel(tipoDeTasa);
        anualidadOrdinaria.getCmbTipoPeriodica().setModel(cmbTipoPeriodicaModel);

        cmbPeriodosModel = new DefaultComboBoxModel(periodos);
        anualidadOrdinaria.getCmbPeriodos().setModel(cmbPeriodosModel);

        format = new DecimalFormat("#.####");

        anualidadOrdinaria.getRbtnVF().addActionListener((e) -> {
            anualidadOrdinaria.getTxtValor().setEnabled(true);

            if (anualidadOrdinaria.getTxtValor().getText().equalsIgnoreCase("digite el valor")) {
                anualidadOrdinaria.getTxtValor().requestFocus();
            }

            CalcularAnualidadActionPerformed();
        });

        anualidadOrdinaria.getRbtnVP().addActionListener((e) -> {
            anualidadOrdinaria.getTxtValor().setEnabled(true);
            if (anualidadOrdinaria.getTxtValor().getText().equalsIgnoreCase("digite el valor")) {
                anualidadOrdinaria.getTxtValor().requestFocus();
            }
            CalcularAnualidadActionPerformed();
        });

        anualidadOrdinaria.getRbtnPeriodica().addActionListener((e) -> {
            anualidadOrdinaria.getCmbTipoPeriodica().setEnabled(true);
            anualidadOrdinaria.getTxtTasa().setEnabled(true);
            anualidadOrdinaria.getLblProcentaje().setEnabled(true);

            if (anualidadOrdinaria.getTxtTasa().getText().equalsIgnoreCase("digite la tasa")) {
                anualidadOrdinaria.getTxtTasa().requestFocus();
            }

            CalcularAnualidadActionPerformed();
        });

        anualidadOrdinaria.getRbtnAnual().addActionListener((e) -> {
            anualidadOrdinaria.getCmbTipoPeriodica().setEnabled(false);
            anualidadOrdinaria.getTxtTasa().setEnabled(true);
            anualidadOrdinaria.getLblProcentaje().setEnabled(true);

            if (anualidadOrdinaria.getTxtTasa().getText().equalsIgnoreCase("digite la tasa")) {
                anualidadOrdinaria.getTxtTasa().requestFocus();
            }

            CalcularAnualidadActionPerformed();
        });

        anualidadOrdinaria.getTxtValor().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadOrdinaria.getTxtValor().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadOrdinaria.getTxtTasa().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadOrdinaria.getTxtTasa().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadOrdinaria.getTxtPeriodos().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadOrdinaria.getTxtPeriodos().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadOrdinaria.getTxtValor().addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                anualidadOrdinaria.getTxtValor().setText("");
                anualidadOrdinaria.getTxtValor().setForeground(Color.BLACK);

                anualidadOrdinaria.getFmdtResultado().setText("NaN");
                anualidadOrdinaria.getFmdtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadOrdinaria.getTxtValor().getText().isBlank()) {
                    return;
                }
                anualidadOrdinaria.getTxtValor().setText("Digite el Valor");
                anualidadOrdinaria.getTxtValor().setForeground(Color.GRAY);
            }
        });
        anualidadOrdinaria.getTxtTasa().addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                anualidadOrdinaria.getTxtTasa().setText("");
                anualidadOrdinaria.getTxtTasa().setForeground(Color.BLACK);

                anualidadOrdinaria.getFmdtResultado().setText("NaN");
                anualidadOrdinaria.getFmdtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadOrdinaria.getTxtTasa().getText().isBlank()) {
                    return;
                }
                anualidadOrdinaria.getTxtTasa().setText("Digite la Tasa");
                anualidadOrdinaria.getTxtTasa().setForeground(Color.GRAY);
            }
        });

        anualidadOrdinaria.getTxtPeriodos().addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                anualidadOrdinaria.getTxtPeriodos().setText("");
                anualidadOrdinaria.getTxtPeriodos().setForeground(Color.BLACK);

                anualidadOrdinaria.getFmdtResultado().setText("NaN");
                anualidadOrdinaria.getFmdtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadOrdinaria.getTxtPeriodos().getText().isBlank()) {
                    return;
                }
                anualidadOrdinaria.getTxtPeriodos().setText("N° de periodos");
                anualidadOrdinaria.getTxtPeriodos().setForeground(Color.GRAY);
            }
        });

        anualidadOrdinaria.getCmbPeriodos().addItemListener((e) -> {
            CalcularAnualidadActionPerformed();
        });

        anualidadOrdinaria.getCmbTipoPeriodica().addItemListener((e) -> {
            CalcularAnualidadActionPerformed();
        });

    }

    private void CalcularAnualidadActionPerformed() {

        if (anualidadOrdinaria.getTxtValor().getText().isBlank() || anualidadOrdinaria.getTxtTasa().getText().isBlank() || anualidadOrdinaria.getTxtPeriodos().getText().isBlank()) {
            anualidadOrdinaria.getFmdtResultado().setText("NaN");
            anualidadOrdinaria.getFmdtResultado().setForeground(Color.GRAY);
            return;
        }

        try {

            if (anualidadOrdinaria.getRbtnVF().isSelected()) {
                if (anualidadOrdinaria.getRbtnAnual().isSelected()) {

                    switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                        case 0 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6))));
                        }
                        case 1 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4))));
                        }
                        case 2 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3))));
                        }
                        case 3 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2))));
                        }
                        case 4 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12))));
                        }
                        case 5 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 1))));
                        }
                    }
                } else if (anualidadOrdinaria.getRbtnPeriodica().isSelected()) {
                    switch (anualidadOrdinaria.getCmbTipoPeriodica().getSelectedIndex()) {

                        case 0 -> {

                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 1))));
                                }

                            }
                        }
                        case 1 -> {
                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 1))));
                                }
                            }
                        }
                        case 2 -> {
                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 12))));
                                }
                                case 5 -> {

                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 1))));
                                }
                            }
                        }
                        case 3 -> {
                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 1))));
                                }
                            }
                        }
                        case 4 -> {

                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorFuturoTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 1))));
                                }
                            }
                        }
                    }
                }
            } else if (anualidadOrdinaria.getRbtnVP().isSelected()) {

                if (anualidadOrdinaria.getRbtnAnual().isSelected()) {
                    switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                        case 0 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6))));
                        }
                        case 1 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4))));

                        }
                        case 2 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3))));

                        }
                        case 3 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2))));

                        }
                        case 4 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12))));

                        }
                        case 5 -> {
                            anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaAnual(
                                    Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 1))));

                        }
                    }
                } else if (anualidadOrdinaria.getRbtnPeriodica().isSelected()) {
                    switch (anualidadOrdinaria.getCmbTipoPeriodica().getSelectedIndex()) {

                        case 0 -> {

                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 6, 1))));
                                }

                            }
                        }
                        case 1 -> {
                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 4, 1))));
                                }
                            }
                        }
                        case 2 -> {
                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 3, 1))));
                                }
                            }
                        }
                        case 3 -> {
                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 2, 1))));
                                }
                            }
                        }
                        case 4 -> {

                            switch (anualidadOrdinaria.getCmbPeriodos().getSelectedIndex()) {
                                case 0 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 6))));
                                }
                                case 1 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 4))));
                                }
                                case 2 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 3))));
                                }
                                case 3 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 2))));
                                }
                                case 4 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 12))));
                                }
                                case 5 -> {
                                    anualidadOrdinaria.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.ordinariaValorPresenteTasaPeriodica(
                                            Float.parseFloat(anualidadOrdinaria.getTxtTasa().getText()), Float.parseFloat(anualidadOrdinaria.getTxtValor().getText()), Float.parseFloat(anualidadOrdinaria.getTxtPeriodos().getText()), 12, 1))));
                                }
                            }
                        }
                    }
                }
            }

            anualidadOrdinaria.getFmdtResultado().setForeground(Color.BLACK);

        } catch (NumberFormatException e) {
            //Nothing
        }

    }

}
