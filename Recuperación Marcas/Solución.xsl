<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:strip-space elements="*"/>
  <xsl:template match="cine">
    <html>
      <body>
      <h1>Enciclopedia de cine</h1>.
      <h2>Gente: </h2>.
      <h3>Directores</h3>
      <xsl:apply-templates select="directores"/>
      <h3>Compositores</h3>
      <xsl:apply-templates select="compositores"/>.
      <h3>Películas</h3>
      <xsl:apply-templates select="peliculas"/>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="directores">
    <xsl:apply-templates/>
  </xsl:template>
  <xsl:template match="director">
  El director de cine
  <strong><xsl:value-of select="./@nombre"/></strong>
  nació en <xsl:value-of select="./@pais_nacimiento"/> en <xsl:value-of select="./@fecha_nacimiento"/>.
</xsl:template>
  <xsl:template match="compositores">
    <xsl:apply-templates/>
  </xsl:template>
  <xsl:template match="compositor">
  El compositor
  <strong><xsl:value-of select="./@nombre"/></strong>
  nació en <xsl:value-of select="./@pais_nacimiento"/> en <xsl:value-of select="./@fecha_nacimiento"/>.
  </xsl:template>
  <xsl:template match="peliculas">
    <xsl:apply-templates/>
  </xsl:template>
  <xsl:template match="pelicula">
  La película
  <strong><xsl:value-of select="./@titulo"/></strong>
  fue dirigada por
  <xsl:value-of select="director"/>.
  </xsl:template>
</xsl:stylesheet>
