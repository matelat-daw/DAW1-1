<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:strip-space elements="*"/>
<xsl:template match="Album">
  <discos>
    <xsl:apply-templates select="disco"/>
  </discos>
</xsl:template>
<xsl:template match="disco">
  <disco>
  <xsl:attribute name="numero">
      <xsl:value-of select="position()"/>
    </xsl:attribute>
    <xsl:attribute name="tipo">
      <xsl:value-of select="musica"/>
    </xsl:attribute>
    <xsl:attribute name="año">
      <xsl:value-of select="fecha/año"/>
    </xsl:attribute>
    <nombre><xsl:value-of select="titulo"/></nombre>
    <canciones><xsl:apply-templates select="cancion"/></canciones>
  </disco>
</xsl:template>
<xsl:template match="cancion">
  <cancion><xsl:value-of select="."/></cancion>
</xsl:template>
</xsl:stylesheet>