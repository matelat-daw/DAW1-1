<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:strip-space elements="*"/>
  <xsl:template match="cine">
    <html>
      <h1>Enciclopedia del cine</h1>
      <h2>Gente</h2>
      <xsl:apply-templates select="directores"/>
      <xsl:apply-templates select="compositores"/>
      <h2>Películas</h2>
      <xsl:apply-templates select="peliculas"/>
    </html>
  </xsl:template>
  <xsl:template match="directores">
    <xsl:apply-templates/>
  </xsl:template>
  <xsl:template match="director">
  <p>El director de cine <strong><xsl:value-of select="./@nombre"/></strong> nació en <xsl:value-of select="./@pais_nacimiento"/> en <xsl:value-of select="./@fecha_nacimiento"/></p>
</xsl:template>
  <xsl:template match="compositores">
    <xsl:apply-templates/>
  </xsl:template>
  <xsl:template match="compositor">
  <p>El compositor <strong><xsl:value-of select="./@nombre"/></strong> nació en <xsl:value-of select="./@pais_nacimiento"/> en <xsl:value-of select="./@fecha_nacimiento"/></p>
  </xsl:template>
  <xsl:template match="peliculas">
    <xsl:apply-templates/>
  </xsl:template>
  <xsl:template match="pelicula">
  <p>La película <strong><xsl:value-of select="./@titulo"/></strong> fue dirigada por <xsl:value-of select="director"/></p>
  </xsl:template>
</xsl:stylesheet>
