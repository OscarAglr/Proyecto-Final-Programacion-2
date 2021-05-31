/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package duarte.programacion2.finalproject.series.mainFrm.controller;

import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadDiferida;
import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadTemplate;
import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadPerpetua;
import duarte.programacion2.finalproject.series.PnlAnualidades.controllers.PnlAnualidadAnticipadaController;
import duarte.programacion2.finalproject.series.PnlAnualidades.controllers.PnlAnualidadDiferidaController;
import duarte.programacion2.finalproject.series.PnlAnualidades.controllers.PnlAnualidadOrdinariaController;
import duarte.programacion2.finalproject.series.PnlAnualidades.controllers.PnlAnualidadPerpetuaController;
import duarte.programacion2.finalproject.series.mainFrm.FrmSeries;
import java.awt.event.ActionEvent;
import javax.swing.event.AncestorEvent;
import javax.swing.event.AncestorListener;
import javax.swing.event.InternalFrameAdapter;
import javax.swing.event.InternalFrameEvent;

/**
 *
 * @author dell
 */
public class FrmSeriesController {

    private final FrmSeries frm;
    private PnlAnualidadTemplate anualidadOrdinaria;
    private PnlAnualidadOrdinariaController ordinariaController;
    private PnlAnualidadTemplate anualidadAnticipada;
    private PnlAnualidadAnticipadaController anticipadaController;
    private PnlAnualidadDiferida anualidadDiferida;
    private PnlAnualidadDiferidaController diferidaController;
    private PnlAnualidadPerpetua anualidadPerpetua;
    private PnlAnualidadPerpetuaController perpetuaController;

    public FrmSeriesController(FrmSeries frm) {
        this.frm = frm;
        initComponent();
    }

    private void initComponent() {

        frm.getMniOrdinaria().addActionListener((ActionEvent e) -> {
            if (anualidadOrdinaria == null) {
                anualidadOrdinaria = new PnlAnualidadTemplate();
                ordinariaController = new PnlAnualidadOrdinariaController(anualidadOrdinaria);
                frm.getDkpMainConteiner().add(anualidadOrdinaria);
                anualidadOrdinaria.setVisible(true);
            }

            anualidadOrdinaria.addInternalFrameListener(new InternalFrameAdapter() {
                @Override
                public void internalFrameClosed(InternalFrameEvent e) {
                    anualidadOrdinaria = null;
                }
            });
        });

        frm.getMniAnticipada().addActionListener((ActionEvent e) -> {
            if (anualidadAnticipada == null) {
                anualidadAnticipada = new PnlAnualidadTemplate();
                anticipadaController = new PnlAnualidadAnticipadaController(anualidadAnticipada);
                frm.getDkpMainConteiner().add(anualidadAnticipada);
                anualidadAnticipada.setVisible(true);
            }

            anualidadAnticipada.addInternalFrameListener(new InternalFrameAdapter() {
                @Override
                public void internalFrameClosed(InternalFrameEvent e) {
                    anualidadAnticipada = null;
                }
            });

        });

        frm.getMniDiferida().addActionListener((ActionEvent e) -> {

            if (anualidadDiferida == null) {
                anualidadDiferida = new PnlAnualidadDiferida();
                diferidaController = new PnlAnualidadDiferidaController(anualidadDiferida);
                frm.getDkpMainConteiner().add(anualidadDiferida);
                anualidadDiferida.setVisible(true);
            }

            anualidadDiferida.addInternalFrameListener(new InternalFrameAdapter() {
                @Override
                public void internalFrameClosed(InternalFrameEvent e) {
                    anualidadDiferida = null;
                }
            });
        });

        frm.getMniPerpetua().addActionListener((ActionEvent e) -> {

            if (anualidadPerpetua == null) {
                anualidadPerpetua = new PnlAnualidadPerpetua();
                perpetuaController = new PnlAnualidadPerpetuaController(anualidadPerpetua);
                frm.getDkpMainConteiner().add(anualidadPerpetua);
                anualidadPerpetua.setVisible(true);
            }

            anualidadPerpetua.addInternalFrameListener(new InternalFrameAdapter() {
                @Override
                public void internalFrameClosed(InternalFrameEvent e) {
                    anualidadPerpetua = null;
                }
            });

        });

    }

}
