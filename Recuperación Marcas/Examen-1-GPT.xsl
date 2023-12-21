<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="xml" indent="yes"/>
  <!-- <xsl:strip-space elements="*"/> -->
  <xsl:template match="Articulos">
    <html>
      <xsl:apply-templates select="Articulo"/>
    </html>
  </xsl:template>
  <xsl:template match="Articulo">
    <p>
      <xsl:value-of select="nombre"/>
    </p>
    <ul>
      <xsl:apply-templates select="autor"/>
    </ul>
  </xsl:template>
  <xsl:template match="autor">
    <li>
      <xsl:value-of select="."/>
    </li>
  </xsl:template>
</xsl:stylesheet>